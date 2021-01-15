namespace Creational.AbstractFactory.Loaning
{
    public abstract class ILoaningAccount : IBankAccount
    {
    }

    // Concrete ( Real ) Product
    public class PersonalLoaningAccount : ILoaningAccount
    {
        public PersonalLoaningAccount(string accountNumber)
        {
            this.Balance = 500_000;
            this.AccountType = AccountType.Personal;
            this.AccountNumber = $"Personal_Loan_{accountNumber}";
        }
    }

    // Concrete ( Real ) Product
    public class CompanyLoaningAccount : ILoaningAccount
    {
        public CompanyLoaningAccount(string accountNumber)
        {
            base.Balance = 1_000_000;
            this.AccountType = AccountType.Personal;
            this.AccountNumber = $"Company_Loan_{accountNumber}";
        }
    }
}