using Edl.Api.Models;
using Edl.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Edl.Api.Controllers;

public sealed class ApplyComplementRequest
{
  public Dictionary<string, object> Cfdi { get; init; } = new();
  public Dictionary<string, object> ComplementData { get; init; } = new();
}

[ApiController]
[Route("api/v1")]
public class ComplementsController(IEdlService service) : ControllerBase
{
  [HttpGet("complements")]
  public async Task<IActionResult> GetComplements(CancellationToken ct)
    => Ok(new { items = await service.GetComplementsAsync(ct) });

  [HttpPost("cfdi/complements/{complementType}")]
  public async Task<ActionResult<OperationResponse>> Apply([FromRoute] string complementType, [FromBody] ApplyComplementRequest request, CancellationToken ct)
  {
    if (request.Cfdi.Count == 0 || request.ComplementData.Count == 0)
      return BadRequest(new ErrorResponse { Message = "cfdi y complementData son requeridos." });

    return Ok(await service.ApplyComplementAsync(complementType, request.Cfdi, request.ComplementData, ct));
  }
}
