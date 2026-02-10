namespace Edl.Api.Models;

public sealed class SatStatusResponse
{
  public string Status { get; init; } = "Desconocido";
  public string CancelationType { get; init; } = string.Empty;
  public string CancelationStatus { get; init; } = string.Empty;
}
