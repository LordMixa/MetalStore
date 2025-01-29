using MetalStore.Data.Entities;
using MetalStore.Data.Repositories.Interfaces;

namespace MetalStore.Data.Repositories;

public class AuditLogRepository : IAuditLogRepository, IDisposable
{
    private readonly MetalStoreContext _metalStoreContext;
    private bool _disposed = false;

    public AuditLogRepository(MetalStoreContext metalStoreContext)
    {
        _metalStoreContext = metalStoreContext;
    }

    public async Task CreateAuditLogAsync(AuditLog auditLog)
    {
        await _metalStoreContext.AuditLogs.AddAsync(auditLog);

        await _metalStoreContext.SaveChangesAsync();
    }

    public virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _metalStoreContext.Dispose();
            }
            _disposed = true;
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
