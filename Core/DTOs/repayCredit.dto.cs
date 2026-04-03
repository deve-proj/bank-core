public class RepayCreditDtoRequest
{
    public string bankId { get; set; } = string.Empty;
    public decimal amount { get; set; }
    public string creditId { get; set; } = string.Empty;
}