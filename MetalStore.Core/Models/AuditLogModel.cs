namespace MetalStore.Core.Models;

public class AuditLogModel
{
    public int AuditLogId { get; set; }
    public DateTime AuditDateAndTime { get; set; }
    public required string HttpMethod { get; set; }
    public string? Request { get; set; }
    public required string Url { get; set; }
    public int StatusCode { get; set; }
    public string? Response { get; set; }
}