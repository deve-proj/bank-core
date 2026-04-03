using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<BankRegistryModel> BankRegistry { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BankRegistryModel>(entity =>
        {
            entity.ToTable("bankRegistry");
            entity.HasKey(e => e.Id).HasName("id");
            
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BankId).HasColumnName("bank_id").IsRequired();
            entity.Property(e => e.BankName).HasColumnName("bank_name").IsRequired();
            entity.Property(e => e.ApiUrl).HasColumnName("api_url").IsRequired();
            entity.Property(e => e.RegisteredAt).HasColumnName("registered_at").IsRequired();
            entity.Property(e => e.OwnerId).HasColumnName("owner_id").IsRequired();
            entity.Property(e => e.ContactEmail).HasColumnName("contact_email").IsRequired();
            entity.Property(e => e.Status).HasColumnName("status").IsRequired();
            
            // Уникальный индекс на BankName (один раз)
            entity.HasIndex(e => e.BankName).IsUnique().HasDatabaseName("ix_bank_registry_bank_name");
        });
    }
}