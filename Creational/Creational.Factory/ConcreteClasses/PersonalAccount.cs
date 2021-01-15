using Creational.Factory.ConcreteContracts;

namespace Creational.Factory.ConcreteClasses
{
    // Concrete ( Real ) Product
    public class PersonalAccount : ISavingAccount
    {
        public PersonalAccount(string accountNumber) 
        {
            this.Balance = 500_000;
            this.AccountType = AccountTypeEnum.Personal;
            this.AccountNumber = $"Personal_{accountNumber}";
        }
    }
}