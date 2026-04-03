public class BankRegistryModel
{
    public int Id { get; set; }
    public string BankId { get; set; } = string.Empty;
    public string BankName { get; set; } = string.Empty;
    public string ApiUrl { get; set; } = string.Empty;
    public DateTime RegisteredAt { get; set; }
    public string OwnerId { get; set; } = string.Empty;
    public string ContactEmail { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty; // Statuses: 'active', 'pending', 'blocked'
}