using System;

namespace  Creational.AbstractFactory.Saving
{
    // Product
    public abstract class ISavingAccount : IBankAccount
    {
    }

    // Concrete ( Real ) Product
    public class CompanySavingAccount : ISavingAccount
    {
        public CompanySavingAccount(string accountNumber)
        {
            base.Balance = 1_000_000;
            this.AccountType = AccountType.Personal;
            this.AccountNumber = $"Company_Save_{accountNumber}";
        }
    }


    // Concrete ( Real ) Product
    public class PersonalSavingAccount : ISavingAccount
    {
        public PersonalSavingAccount(string accountNumber)
        {
            this.Balance = 500_000;
            this.AccountType = AccountType.Personal;
            this.AccountNumber = $"Personal_Save_{accountNumber}";
        }
    }
}