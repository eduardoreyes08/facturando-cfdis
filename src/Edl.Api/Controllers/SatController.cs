using Edl.Api.Models;
using Edl.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Edl.Api.Controllers;

[ApiController]
[Route("api/v1/sat")]
public class SatController(IEdlService service) : ControllerBase
{
  [HttpGet("cfdi-status")]
  public async Task<ActionResult<SatStatusResponse>> Status(
    [FromQuery] string rfcEmisor,
    [FromQuery] string rfcReceptor,
    [FromQuery] string uuid,
    [FromQuery] decimal total,
    CancellationToken ct)
  {
    if (string.IsNullOrWhiteSpace(rfcEmisor) || string.IsNullOrWhiteSpace(rfcReceptor) || string.IsNullOrWhiteSpace(uuid))
      return BadRequest(new ErrorResponse { Message = "rfcEmisor, rfcReceptor y uuid son requeridos." });

    return Ok(await service.GetSatStatusAsync(rfcEmisor, rfcReceptor, uuid, total, ct));
  }
}
