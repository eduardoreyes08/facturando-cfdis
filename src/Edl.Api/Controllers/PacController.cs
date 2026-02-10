using Edl.Api.Models;
using Edl.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Edl.Api.Controllers;

[ApiController]
[Route("api/v1/pac")]
public class PacController(IEdlService service) : ControllerBase
{
  [HttpGet("time")]
  public async Task<ActionResult<PacTimeResponse>> Time([FromQuery] string provider = "ecodex", CancellationToken ct = default)
    => Ok(await service.GetPacTimeAsync(provider, ct));

  [HttpGet("account-status")]
  public async Task<ActionResult<PacAccountStatusResponse>> AccountStatus([FromQuery] string provider, [FromQuery] string rfc, CancellationToken ct)
  {
    if (string.IsNullOrWhiteSpace(provider) || string.IsNullOrWhiteSpace(rfc))
      return BadRequest(new ErrorResponse { Message = "provider y rfc son requeridos." });

    return Ok(await service.GetPacAccountStatusAsync(provider, rfc, ct));
  }
}
