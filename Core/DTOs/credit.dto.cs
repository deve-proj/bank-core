public class CreditDto
{
    public string BankId { get; set; } = string.Empty;
    public int Amount { get; set; }
    public int TermDays { get; set; }
    public string Purpose { get; set; } = string.Empty;
    public decimal Rate { get; set; }
    public string IdempotencyKey { get; set; } = Guid.NewGuid().ToString();
}