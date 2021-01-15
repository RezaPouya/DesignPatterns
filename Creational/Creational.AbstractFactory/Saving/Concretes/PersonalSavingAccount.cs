using Creational.AbstractFactory.Enums;

namespace Creational.AbstractFactory.Saving.Concretes
{
    // Concrete ( Real ) Product
    public class PersonalSavingAccount : ISavingAccount
    {
        public PersonalSavingAccount(string accountNumber)
        {
            this.Balance = 500_000;
            this.AccountType = AccountTypeEnum.Personal;
            this.AccountNumber = $"Personal_Save_{accountNumber}";
        }
    }
}