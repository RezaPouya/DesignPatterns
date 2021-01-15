using Creational.Factory.ConcreteClasses;
using System;
using Xunit;

namespace Creational.Factory
{
    public class DesignPatternFactoryTest
    {
        private IAccountFactory _accountFactory => new AccountFactory();

        [Fact]
        public void Should_Throw_Exception_If_Account_Number_Is_Empty()
        {
            Action act = () =>  _accountFactory.GetSavingAccount(AccountTypeEnum.NA, "");
            Assert.Throws<Exception>(act);
        }

        [Fact]
        public void Should_Throw_Exception_If_Account_Type_Is_Not_Specified()
        {
            Action act = () => _accountFactory.GetSavingAccount(AccountTypeEnum.NA, "9988776655");
            Assert.Throws<Exception>(act);
        }

        [Fact]
        public void Should_Pass_If_Created_Account_Is_Personal_Account()
        {
            var account = _accountFactory.GetSavingAccount(AccountTypeEnum.Personal, "9988776655");

            Assert.IsType<PersonalAccount>(account);
        }


        [Fact]
        public void Should_Pass_If_Created_Account_Is_Personal_Account_And_Have_Valid_AccountNumber()
        {
            var account = _accountFactory.GetSavingAccount(AccountTypeEnum.Personal, "9988776655");

            Assert.IsType<PersonalAccount>(account);
            Assert.Contains("Personal_", account.AccountNumber);
        }

        [Fact]
        public void Should_Pass_If_Created_Account_Is_Company_Account()
        {
            var account = _accountFactory.GetSavingAccount(AccountTypeEnum.Company, "9988776655");

            Assert.IsType<CompanyAccount>(account);
        }

        [Fact]
        public void Should_Pass_If_Created_Account_Is_Company_Account_And_Have_Valid_AccountNumber()
        {
            var account = _accountFactory.GetSavingAccount(AccountTypeEnum.Company, "9988776655");

            Assert.IsType<CompanyAccount>(account);
            Assert.Contains("Company_", account.AccountNumber);
        }
    }
}
