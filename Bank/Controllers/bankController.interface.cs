using Microsoft.AspNetCore.Mvc;

interface IBankController
{
    Task<ActionResult> RequestCredit(CreditDto creditInfo);
    Task<ActionResult> RepayCredit(RepayCreditDtoRequest repayRequest);
    Task<ActionResult<CreditDto[]>> GetCreditsInfo();
    Task<ActionResult<CreditDto>> GetCreditInfo(string creditId);
    Task<ActionResult<decimal>> GetKeyRate();
    Task<ActionResult<decimal>> GetReserveRequirementRatio();
    Task<ActionResult<decimal>> GetReserveBalance(string bankId);
    Task<ActionResult> DepositReserves(ReservesOperationDto depositRequest);
    Task<ActionResult> WithdrawReserves(ReservesOperationDto withdrawReservesRequest);
}