using Microsoft.EntityFrameworkCore;

public interface IBankRegistryRepo
{
    public Task<BankRegistryModel?> GetBankInfo(string bankId);
    public Task<bool> RegistNewBank(BankRegistryModel bankData);
    public Task<bool> DeleteBankFromRegistry(string bankId);
}

public class BankRegistryRepo : IBankRegistryRepo
{
    private readonly ApplicationDbContext _context;

    public BankRegistryRepo(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<BankRegistryModel?> GetBankInfo(string bankId)
    {
        return new BankRegistryModel();
    }

    public async Task<bool> RegistNewBank(BankRegistryModel bankData)
    {
        try
        {
            await _context.BankRegistry.AddAsync(bankData);
            await _context.SaveChangesAsync();

            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> DeleteBankFromRegistry(string bankId)
    {
        return true;
    }    
}