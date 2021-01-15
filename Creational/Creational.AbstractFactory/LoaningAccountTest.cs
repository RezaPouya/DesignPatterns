using Creational.AbstractFactory.Loaning;
using Creational.AbstractFactory.Saving;
using System;
using Xunit;

namespace Creational.AbstractFactory
{
    public class LoaningAccountTest
    {
        private ICreditAccountFactory _accountFactory => new CreditAccountFactory();

        [Fact]
        public void Should_Throw_Exception_If_Account_Number_Is_Empty()
        {
            Action act = () => _accountFactory.CreateLoaningAccount(AccountType.NA, "");
            Assert.Throws<Exception>(act);
        }

        [Fact]
        public void Should_Throw_Exception_If_Account_Type_Is_Not_Specified()
        {
            Action act = () => _accountFactory.CreateLoaningAccount(AccountType.NA, "9988776655");
            Assert.Throws<Exception>(act);
        }

        [Fact]
        public void Should_Pass_If_Created_Account_Is_Personal_Account()
        {
            var account = _accountFactory.CreateLoaningAccount(AccountType.Personal, "9988776655");

            Assert.IsType<PersonalLoaningAccount>(account);
        }


        [Fact]
        public void Should_Pass_If_Created_Account_Is_Personal_Account_And_Have_Valid_AccountNumber()
        {
            var account = _accountFactory.CreateLoaningAccount(AccountType.Personal, "9988776655");

            Assert.IsType<PersonalLoaningAccount>(account);
            Assert.Contains("Personal_Loan_", account.AccountNumber);
        }

        [Fact]
        public void Should_Pass_If_Created_Account_Is_Company_Account()
        {
            var account = _accountFactory.CreateLoaningAccount(AccountType.Company, "9988776655");

            Assert.IsType<CompanyLoaningAccount>(account);
        }

        [Fact]
        public void Should_Pass_If_Created_Account_Is_Company_Account_And_Have_Valid_AccountNumber()
        {
            var account = _accountFactory.CreateLoaningAccount(AccountType.Company, "9988776655");

            Assert.IsType<CompanyLoaningAccount>(account);
            Assert.Contains("Company_Loan_", account.AccountNumber);
        }
    }
}
