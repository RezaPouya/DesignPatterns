using Creational.AbstractFactory.Enums;

namespace Creational.AbstractFactory.Saving.Concretes
{
    // Concrete ( Real ) Product
    public class CompanySavingAccount : ISavingAccount
    {
        public CompanySavingAccount(string accountNumber)
        {
            base.Balance = 1_000_000;
            this.AccountType = AccountTypeEnum.Personal;
            this.AccountNumber = $"Company_Save_{accountNumber}";
        }
    }
}