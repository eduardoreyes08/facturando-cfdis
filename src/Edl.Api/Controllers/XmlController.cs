using Edl.Api.Models;
using Edl.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Edl.Api.Controllers;

[ApiController]
[Route("api/v1/xml")]
public class XmlController(IEdlService service) : ControllerBase
{
  [HttpPost("validate/cfdi")]
  public async Task<ActionResult<ValidateXmlResponse>> ValidateCfdi([FromBody] ValidateCfdiXmlRequest request, CancellationToken ct)
  {
    if (string.IsNullOrWhiteSpace(request.XmlBase64))
      return BadRequest(new ErrorResponse { Message = "xmlBase64 es requerido." });

    return Ok(await service.ValidateCfdiXmlAsync(request, ct));
  }

  [HttpPost("validate/retentions")]
  public async Task<ActionResult<OperationResponse>> ValidateRetentions([FromBody] ValidateRetentionsXmlRequest request, CancellationToken ct)
  {
    if (string.IsNullOrWhiteSpace(request.XmlBase64))
      return BadRequest(new ErrorResponse { Message = "xmlBase64 es requerido." });

    return Ok(await service.ValidateRetentionsXmlAsync(request, ct));
  }

  [HttpPost("parse/cfdi")]
  public async Task<IActionResult> ParseCfdi([FromBody] ParseCfdiXmlRequest request, CancellationToken ct)
  {
    if (string.IsNullOrWhiteSpace(request.XmlBase64))
      return BadRequest(new ErrorResponse { Message = "xmlBase64 es requerido." });

    return Ok(await service.ParseCfdiXmlAsync(request, ct));
  }
}
