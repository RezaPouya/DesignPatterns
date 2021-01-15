using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.AbstractFactory.Loaning
{
    public interface ILoaningAccountFactory
    {
        ILoaningAccount CreateAccount(AccountType accountType, string accountNumber);
    }

    public class LoaningAccountFactory : ILoaningAccountFactory
    {
        public ILoaningAccount CreateAccount(AccountType accountType, string accountNumber)
        {
            if (string.IsNullOrEmpty(accountNumber))
                throw new Exception("The account number cannot be null");

            switch (accountType)
            {
                case AccountType.NA: 
                    throw new Exception("The Account can only be Personal or Company Account , Please specify acount type ");

                case AccountType.Personal:
                    return new PersonalLoaningAccount(accountNumber);

                case AccountType.Company:
                    return new CompanyLoaningAccount(accountNumber);

                default:
                    throw new Exception("The Account can only be Personal or Company Account , Please specify acount type ");

            }
        }
    }
}
