using Creational.AbstractFactory.Loaning;
using Creational.AbstractFactory.Saving;
using System;

namespace Creational.AbstractFactory
{
    public class CreditAccountFactory : ICreditAccountFactory
    {
        public override IBankAccount CreateAccount(AccountType accountType, string accountNumber, AccountCatagory accountCatagory)
        {
            switch (accountCatagory)
            {
                case AccountCatagory.Loaning:
                    return this.CreateLoaningAccount(accountType, accountNumber);

                case AccountCatagory.Saving:
                    return this.CreateSavingAccount(accountType, accountNumber);

                default: 
                    throw new Exception("The account can only be Saving or Loaning account, Please specify valid acount account category");
            }
        }

        public override ILoaningAccount CreateLoaningAccount(AccountType accountType, string accountNumber)
        {
            ILoaningAccountFactory factory = new LoaningAccountFactory();

            return factory.CreateAccount(accountType: accountType
                , accountNumber: accountNumber);
        }

        public override ISavingAccount CreateSavingAccount(AccountType accountType, string accountNumber)
        {
            ISavingAccountFactory factory = new SavingAccountFactory();

            return factory.CreateAccount(accountType: accountType
                , accountNumber: accountNumber);
        }
    }
}