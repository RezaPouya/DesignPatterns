using Creational.AbstractFactory.Enums;
using Creational.AbstractFactory.Loaning.Concretes;
using System;

namespace Creational.AbstractFactory.Loaning
{
    public class LoaningAccountFactory : ILoaningAccountFactory
    {
        public ILoaningAccount CreateAccount(AccountTypeEnum accountType, string accountNumber)
        {
            if (string.IsNullOrEmpty(accountNumber))
                throw new Exception("The account number cannot be null");

            switch (accountType)
            {
                case AccountTypeEnum.NA: 
                    throw new Exception("The Account can only be Personal or Company Account , Please specify acount type ");

                case AccountTypeEnum.Personal:
                    return new PersonalLoaningAccount(accountNumber);

                case AccountTypeEnum.Company:
                    return new CompanyLoaningAccount(accountNumber);

                default:
                    throw new Exception("The Account can only be Personal or Company Account , Please specify acount type ");

            }
        }
    }
}
