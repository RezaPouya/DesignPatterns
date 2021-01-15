using Creational.AbstractFactory.Enums;
using Creational.AbstractFactory.Saving.Concretes;
using System;

namespace Creational.AbstractFactory.Saving
{
    public class SavingAccountFactory : ISavingAccountFactory
    {
        public ISavingAccount CreateAccount(AccountTypeEnum accountType, string accountNumber)
        {
            if (string.IsNullOrEmpty(accountNumber))
                throw new Exception("The account number cannot be null");

            switch (accountType)
            {
                case AccountTypeEnum.NA: throw new Exception("The Account can only be Personal or Company Account , Please specify acount type ");
                case AccountTypeEnum.Personal: return new PersonalSavingAccount(accountNumber);
                case AccountTypeEnum.Company: return new CompanySavingAccount(accountNumber);
                default: throw new Exception("The Account can only be Personal or Company Account , Please specify acount type ");
            }
        }
    }
}