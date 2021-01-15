using Creational.Factory.ConcreteContracts;

namespace Creational.Factory.ConcreteClasses
{
    // Concrete ( Real ) Product
    public class CompanyAccount : ISavingAccount
    {
        public CompanyAccount(string accountNumber)
        {
            base.Balance = 1_000_000;
            this.AccountType = AccountTypeEnum.Personal;
            this.AccountNumber = $"Company_{accountNumber}";
        }
    }
}