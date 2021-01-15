using Creational.AbstractFactory.Loaning;
using Creational.AbstractFactory.Saving;
using System;
using Xunit;

namespace Creational.AbstractFactory
{
    public class AccountTest
    {
        private ICreditAccountFactory _accountFactory => new CreditAccountFactory();

        [Fact]
        public void Should_Pass_If_Can_Create_Personal_Loaning_Account()
        {
            var account = _accountFactory.CreateAccount(AccountType.Personal, "9988776655" , AccountCatagory.Loaning);

            Assert.IsType<PersonalLoaningAccount>(account);
            Assert.Contains("Personal_Loan_", account.AccountNumber);
        }

        [Fact]
        public void Should_Pass_If_Can_Create_Personal_Saving_Account()
        {
            var account = _accountFactory.CreateAccount(AccountType.Personal, "9988776655", AccountCatagory.Saving);

            Assert.IsType<PersonalSavingAccount>(account);
            Assert.Contains("Personal_Save_", account.AccountNumber);
        }

        [Fact]
        public void Should_Throw_Exception_If_Account_Catagory_Is_Not_Valid()
        {
            // Arrange 

            // Act 

            // Assert
            Action act = () => _accountFactory.CreateAccount(AccountType.Personal, "9988776655", AccountCatagory.NA);

            Assert.Throws<Exception>(act);
        }
    }
}
