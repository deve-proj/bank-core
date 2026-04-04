using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<BankRegistryModel> BankRegistry { get; set; }
    public DbSet<MonetaryPolicyModel> MonetaryPolicy { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BankRegistryModel>(entity =>
        {
            entity.ToTable("bank_registry");
            entity.HasKey(e => e.Id);
            
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BankId).HasColumnName("bank_id").IsRequired();
            entity.Property(e => e.BankName).HasColumnName("bank_name").IsRequired();
            entity.Property(e => e.ApiUrl).HasColumnName("api_url").IsRequired();
            entity.Property(e => e.RegisteredAt).HasColumnName("registered_at").IsRequired();
            entity.Property(e => e.OwnerId).HasColumnName("owner_id").IsRequired();
            entity.Property(e => e.ContactEmail).HasColumnName("contact_email").IsRequired();
            entity.Property(e => e.Status).HasColumnName("status").IsRequired();

            entity.HasIndex(e => e.BankName).IsUnique().HasDatabaseName("ix_bank_registry_bank_name");
        });

        modelBuilder.Entity<MonetaryPolicyModel>(entity =>
        {
            entity.ToTable("monetary_policy");
            entity.HasKey(e => e.Id);
            
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.KeyRate).HasColumnName("key_rate").IsRequired();
            entity.Property(e => e.ReserveRatio).HasColumnName("reserve_ratio").IsRequired();
            entity.Property(e => e.TotalMoneySupply).HasColumnName("total_money_supply").IsRequired();
            entity.Property(e => e.Inflation).HasColumnName("inflation").IsRequired();
            entity.Property(e => e.IsCurrent).HasColumnName("is_current").IsRequired();
            entity.Property(e => e.CreatedAt).HasColumnName("created_at").IsRequired();
            entity.Property(e => e.DeprecatedAt).HasColumnName("deprecated_at");
            entity.Property(e => e.ChangedBy).HasColumnName("changed_by").IsRequired();
            entity.Property(e => e.DecisionUrl).HasColumnName("decision_url");
        });
    }
}