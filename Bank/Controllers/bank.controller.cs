using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

[ApiController]
public class BankController : ControllerBase, IBankController
{
    private readonly IBankService _bankService;

    public BankController(IBankService bankService)
    {
        _bankService = bankService;
    }

    [HttpPost("registBank")]
    public async Task<ActionResult> RegistNewBank([FromBody] BankRegistryModel bankData)
    {
        bool result = await _bankService.RegistNewBank(bankData);

        if(result)
            return Ok("Bank was successfully registed");
        else
            return BadRequest("Error while registing your bank");
    }

    [HttpPost("requestCredit")]
    public async Task<ActionResult> RequestCredit([FromBody] CreditDto creditInfo)
    {
        return Ok();
    }

    [HttpPost("repayCredit")]
    public async Task<ActionResult> RepayCredit([FromBody] RepayCreditDtoRequest repayRequest)
    {
        return Ok();
    }

    [HttpGet("keyRate")]
    public async Task<ActionResult<decimal>> GetKeyRate()
    {
        return Ok("Your balance: НИХУЯ");
    }

    [HttpGet("credit/{creditId}")]
    public async Task<ActionResult<CreditDto>> GetCreditInfo(string creditId)
    {
        return Ok();
    }

    [HttpGet("credit")]
    public async Task<ActionResult<CreditDto[]>> GetCreditsInfo()
    {
        return Ok();
    }

    [HttpGet("reserveRequirementRatio")]
    public async Task<ActionResult<decimal>> GetReserveRequirementRatio()
    {
        return Ok();
    }

    [HttpGet("balance")]
    public async Task<ActionResult<decimal>> GetReserveBalance([FromQuery] string bankId)
    {
        return Ok();
    }

    [HttpPost("depositReserves")]
    public async Task<ActionResult> DepositReserves([FromBody] ReservesOperationDto depositRequest)
    {
        return Ok();
    }

    [HttpPost("withdrawReserves")]
    public async Task<ActionResult> WithdrawReserves([FromBody] ReservesOperationDto withdrawReservesRequest)
    {
        return Ok();
    }
}