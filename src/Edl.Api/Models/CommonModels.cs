namespace Edl.Api.Models;

public record OperationResponse(bool Success, string Message, string TransactionId, IReadOnlyList<string>? Errors = null);
public record HealthResponse(string Status, DateTimeOffset Timestamp, string Version);

public sealed class ErrorResponse
{
  public string Message { get; init; } = string.Empty;
  public IReadOnlyList<string> Errors { get; init; } = Array.Empty<string>();
}
