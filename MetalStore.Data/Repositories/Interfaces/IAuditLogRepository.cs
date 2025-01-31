using MetalStore.Data.Entities;

namespace MetalStore.Data.Repositories.Interfaces;

public interface IAuditLogRepository
{
    Task CreateAuditLogAsync(AuditLog auditLog);
}
