using Creational.Factory.ConcreteClasses;
using Creational.Factory.ConcreteContracts;
using System;

namespace Creational.Factory
{
    public class AccountFactory : IAccountFactory
    {
        public ISavingAccount GetSavingAccount(AccountTypeEnum accountType, string accountNumber)
        {
            if (string.IsNullOrEmpty(accountNumber))
                throw new Exception("The account number cannot be null");

            switch (accountType)
            {
                case AccountTypeEnum.NA:
                    throw new Exception("The Account can only be Personal or Company Account , Please specify acount type ");
                
                case AccountTypeEnum.Personal:
                    return new PersonalAccount(accountNumber);
                
                case AccountTypeEnum.Company: 
                    return new CompanyAccount(accountNumber);
                
                default: 
                    throw new Exception("The Account can only be Personal or Company Account , Please specify acount type ");
            }
        }
    }
}