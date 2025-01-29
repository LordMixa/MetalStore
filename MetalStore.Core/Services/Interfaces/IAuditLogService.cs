using MetalStore.Core.Models;

namespace MetalStore.Core.Services.Interfaces;

public interface IAuditLogService
{
    Task CreateAuditLogAsync(AuditLogModel auditLogModel);
}
