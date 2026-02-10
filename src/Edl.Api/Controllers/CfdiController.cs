using Edl.Api.Models;
using Edl.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Edl.Api.Controllers;

[ApiController]
[Route("api/v1/cfdi")]
public class CfdiController(IEdlService service) : ControllerBase
{
  [HttpPost("stamp")]
  public async Task<ActionResult<StampResponse>> Stamp([FromBody] StampCfdiRequest request, CancellationToken ct)
  {
    if (request.Cfdi.Count == 0)
      return BadRequest(new ErrorResponse { Message = "cfdi es requerido." });

    return Ok(await service.StampCfdiAsync(request, ct));
  }

  [HttpPost("cancel")]
  public async Task<ActionResult<OperationResponse>> Cancel([FromBody] CancelCfdiRequest request, CancellationToken ct)
  {
    if (string.IsNullOrWhiteSpace(request.RfcEmisor) || string.IsNullOrWhiteSpace(request.Uuid) || string.IsNullOrWhiteSpace(request.Motivo))
      return BadRequest(new ErrorResponse { Message = "rfcEmisor, uuid y motivo son requeridos." });

    return Ok(await service.CancelCfdiAsync(request, ct));
  }

  [HttpGet("cancel-receipt")]
  public async Task<ActionResult<CancelReceiptResponse>> CancelReceipt([FromQuery] string rfcEmisor, [FromQuery] string uuid, CancellationToken ct)
  {
    if (string.IsNullOrWhiteSpace(rfcEmisor) || string.IsNullOrWhiteSpace(uuid))
      return BadRequest(new ErrorResponse { Message = "rfcEmisor y uuid son requeridos." });

    return Ok(await service.GetCancelReceiptAsync(rfcEmisor, uuid, ct));
  }

  [HttpGet("{uuid}/xml")]
  public async Task<ActionResult<CfdiXmlResponse>> DownloadXml([FromRoute] string uuid, [FromQuery] string rfcEmisor, CancellationToken ct)
  {
    if (string.IsNullOrWhiteSpace(rfcEmisor))
      return BadRequest(new ErrorResponse { Message = "rfcEmisor es requerido." });

    return Ok(await service.GetCfdiXmlAsync(rfcEmisor, uuid, ct));
  }
}
