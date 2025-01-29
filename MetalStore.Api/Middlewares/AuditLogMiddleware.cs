using MetalStore.Core.Models;
using MetalStore.Core.Services.Interfaces;
using MetalStore.Core.Extensions;

namespace MetalStore.Api.Middlewares;

public class AuditLogMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IServiceScopeFactory _scopeFactory;

    public AuditLogMiddleware(RequestDelegate next, IServiceScopeFactory scopeFactory)
    {
        _next = next;
        _scopeFactory = scopeFactory;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var auditLogModel = new AuditLogModel
        {
            HttpMethod = context.Request.Method,
            Request = await context.GetBody(),
            Url = context.Request.Path
        };

        var originalBodyStream = context.Response.Body;

        using (var responseBodyStream = new MemoryStream())
        {
            context.Response.Body = responseBodyStream;

            await _next(context);

            auditLogModel.StatusCode = context.Response.StatusCode;

            auditLogModel.Response = await context.GetResponse();

            await responseBodyStream.CopyToAsync(originalBodyStream);

            await AuditAsync(auditLogModel);
        }
    }

    private async Task AuditAsync(AuditLogModel auditLogModel)
    {
        using (var scope = _scopeFactory.CreateScope())  
        {
            var auditLogService = scope.ServiceProvider.GetRequiredService<IAuditLogService>();

            await auditLogService.CreateAuditLogAsync(auditLogModel);
        }
    }
}
