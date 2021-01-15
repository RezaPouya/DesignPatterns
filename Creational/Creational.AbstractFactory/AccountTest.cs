using Creational.AbstractFactory.Enums;
using Creational.AbstractFactory.Loaning;
using Creational.AbstractFactory.Loaning.Concretes;
using Creational.AbstractFactory.Saving;
using Creational.AbstractFactory.Saving.Concretes;
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
            var account = _accountFactory.CreateAccount(AccountTypeEnum.Personal, "9988776655" , AccountCatagoryEnum.Loaning);

            Assert.IsType<PersonalLoaningAccount>(account);
            Assert.Contains("Personal_Loan_", account.AccountNumber);
        }

        [Fact]
        public void Should_Pass_If_Can_Create_Personal_Saving_Account()
        {
            var account = _accountFactory.CreateAccount(AccountTypeEnum.Personal, "9988776655", AccountCatagoryEnum.Saving);

            Assert.IsType<PersonalSavingAccount>(account);
            Assert.Contains("Personal_Save_", account.AccountNumber);
        }

        [Fact]
        public void Should_Throw_Exception_If_Account_Catagory_Is_Not_Valid()
        {
            // Arrange 

            // Act 

            // Assert
            Action act = () => _accountFactory.CreateAccount(AccountTypeEnum.Personal, "9988776655", AccountCatagoryEnum.NA);

            Assert.Throws<Exception>(act);
        }
    }
}
