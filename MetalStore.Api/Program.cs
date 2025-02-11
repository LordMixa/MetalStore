using MetalStore.Api.MapperConfigurations;
using MetalStore.Api.Middlewares;

namespace MetalStore.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var allowAll = "AllowAll";

        builder.Services.AddCors(options =>
        {
            options.AddPolicy(allowAll, policy =>
            {
                policy.AllowAnyOrigin()
                      .AllowAnyMethod()
                      .AllowAnyHeader();
            });
        });

        builder.Services.AddAutoMapper(typeof(ContractsMappingProfile));

        string connectionString = builder.Configuration.GetConnectionString("MetalStoreDb");

        Core.Configuration.Configure(builder.Services, connectionString);

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseCors(allowAll);

        app.UseMiddleware<ExceptionMiddleware>();

        app.UseMiddleware<AuditLogMiddleware>();

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
