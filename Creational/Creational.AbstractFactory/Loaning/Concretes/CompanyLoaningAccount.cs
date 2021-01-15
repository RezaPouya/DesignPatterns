using Creational.AbstractFactory.Enums;

namespace Creational.AbstractFactory.Loaning.Concretes
{
    // Concrete ( Real ) Product
    public class CompanyLoaningAccount : ILoaningAccount
    {
        public CompanyLoaningAccount(string accountNumber)
        {
            base.Balance = 1_000_000;
            this.AccountType = AccountTypeEnum.Personal;
            this.AccountNumber = $"Company_Loan_{accountNumber}";
        }
    }
}