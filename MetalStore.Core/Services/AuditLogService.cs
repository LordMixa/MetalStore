using AutoMapper;
using MetalStore.Core.Models;
using MetalStore.Core.Services.Interfaces;
using MetalStore.Data.Entities;
using MetalStore.Data.Repositories.Interfaces;

namespace MetalStore.Core.Services;

public class AuditLogService : IAuditLogService
{
    private readonly IMapper _mapper;
    private readonly IAuditLogRepository _auditLogRepository;

    public AuditLogService(IMapper mapper, IAuditLogRepository auditLogRepository)
    {
        _mapper = mapper;
        _auditLogRepository = auditLogRepository;
    }

    public async Task CreateAuditLogAsync(AuditLogModel auditLogModel)
    {
        var auditLog = _mapper.Map<AuditLog>(auditLogModel);

        await _auditLogRepository.CreateAuditLogAsync(auditLog);
    }
}
