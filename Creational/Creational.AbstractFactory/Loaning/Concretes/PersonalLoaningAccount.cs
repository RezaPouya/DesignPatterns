using Creational.AbstractFactory.Enums;

namespace Creational.AbstractFactory.Loaning.Concretes
{
    // Concrete ( Real ) Product
    public class PersonalLoaningAccount : ILoaningAccount
    {
        public PersonalLoaningAccount(string accountNumber)
        {
            this.Balance = 500_000;
            this.AccountType = AccountTypeEnum.Personal;
            this.AccountNumber = $"Personal_Loan_{accountNumber}";
        }
    }
}