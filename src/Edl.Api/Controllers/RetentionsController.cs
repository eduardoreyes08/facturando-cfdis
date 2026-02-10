using Edl.Api.Models;
using Edl.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Edl.Api.Controllers;

[ApiController]
[Route("api/v1/retentions")]
public class RetentionsController(IEdlService service) : ControllerBase
{
  [HttpPost("stamp")]
  public async Task<ActionResult<StampResponse>> Stamp([FromBody] StampRetentionsRequest request, CancellationToken ct)
  {
    if (request.Retentions.Count == 0)
      return BadRequest(new ErrorResponse { Message = "retentions es requerido." });

    return Ok(await service.StampRetentionsAsync(request, ct));
  }
}
