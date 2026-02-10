namespace Edl.Api.Models;

public sealed class PacTimeResponse
{
  public DateTimeOffset ServerTime { get; init; }
  public DateTimeOffset LocalTime { get; init; }
  public string Provider { get; init; } = string.Empty;
}

public sealed class PacAccountStatusResponse
{
  public string Provider { get; init; } = string.Empty;
  public string Rfc { get; init; } = string.Empty;
  public string Status { get; init; } = string.Empty;
  public int TimbresAvailable { get; init; }
}
