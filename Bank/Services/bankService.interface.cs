public interface IBankService
{
    public Task<bool> RegistNewBank(BankRegistryModel bankData);
}