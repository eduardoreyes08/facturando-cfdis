using Edl.Api.Models;
using Edl.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Edl.Api.Controllers;

public sealed class ApplyAddendaRequest
{
  public string XmlBase64 { get; init; } = string.Empty;
  public Dictionary<string, object> AddendaData { get; init; } = new();
}

[ApiController]
[Route("api/v1")]
public class AddendasController(IEdlService service) : ControllerBase
{
  [HttpGet("addendas")]
  public async Task<IActionResult> GetAddendas(CancellationToken ct)
    => Ok(new { items = await service.GetAddendasAsync(ct) });

  [HttpPost("cfdi/addendas/{addendaType}")]
  public async Task<ActionResult<OperationResponse>> Apply([FromRoute] string addendaType, [FromBody] ApplyAddendaRequest request, CancellationToken ct)
  {
    if (string.IsNullOrWhiteSpace(request.XmlBase64) || request.AddendaData.Count == 0)
      return BadRequest(new ErrorResponse { Message = "xmlBase64 y addendaData son requeridos." });

    return Ok(await service.ApplyAddendaAsync(addendaType, request.XmlBase64, request.AddendaData, ct));
  }
}
