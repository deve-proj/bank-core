public class MonetaryPolicyModel
{
    public int Id {get; set;  }
    public decimal KeyRate { get; set; }
    public decimal ReserveRatio { get; set; }
    public decimal TotalMoneySupply { get; set; }
    public decimal Inflation { get; set; }
    public bool IsCurrent { get; set; } // SCD Type 2
    public DateTime CreatedAt { get; set; }
    public DateTime? DeprecatedAt { get; set; }
    public string ChangedBy { get; set; } = string.Empty;
    public string DecisionUrl { get; set; } = string.Empty;
}