public class BankService : IBankService
{
    private readonly IBankRegistryRepo _repo;
    
    public BankService(IBankRegistryRepo repo)
    {
        _repo = repo;
    }

    public async Task<bool> RegistNewBank(BankRegistryModel bankData)
    {
        bankData.RegisteredAt = DateTime.UtcNow;
        return await _repo.RegistNewBank(bankData);
    }

}