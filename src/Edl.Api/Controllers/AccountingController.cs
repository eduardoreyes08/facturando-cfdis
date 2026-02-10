using Edl.Api.Models;
using Edl.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Edl.Api.Controllers;

[ApiController]
[Route("api/v1/accounting")]
public class AccountingController(IEdlService service) : ControllerBase
{
  [HttpPost("catalog")]
  public async Task<ActionResult<AccountingXmlResponse>> Catalog([FromBody] AccountingRequest request, CancellationToken ct)
    => Ok(await service.GenerateAccountingCatalogAsync(request, ct));

  [HttpPost("trial-balance")]
  public async Task<ActionResult<AccountingXmlResponse>> TrialBalance([FromBody] AccountingRequest request, CancellationToken ct)
    => Ok(await service.GenerateAccountingTrialBalanceAsync(request, ct));

  [HttpPost("policy")]
  public async Task<ActionResult<AccountingXmlResponse>> Policy([FromBody] AccountingRequest request, CancellationToken ct)
    => Ok(await service.GenerateAccountingPolicyAsync(request, ct));

  [HttpPost("aux-accounts")]
  public async Task<ActionResult<AccountingXmlResponse>> AuxAccounts([FromBody] AccountingRequest request, CancellationToken ct)
    => Ok(await service.GenerateAccountingAuxAccountsAsync(request, ct));

  [HttpPost("aux-folios")]
  public async Task<ActionResult<AccountingXmlResponse>> AuxFolios([FromBody] AccountingRequest request, CancellationToken ct)
    => Ok(await service.GenerateAccountingAuxFoliosAsync(request, ct));
}
