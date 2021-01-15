using Creational.AbstractFactory.Enums;
using Creational.AbstractFactory.Loaning;
using Creational.AbstractFactory.Saving;
using System;

namespace Creational.AbstractFactory
{
    public class CreditAccountFactory : ICreditAccountFactory
    {
        public override IBankAccount CreateAccount(AccountTypeEnum accountType, string accountNumber, AccountCatagoryEnum accountCatagory)
        {
            switch (accountCatagory)
            {
                case AccountCatagoryEnum.Loaning:
                    return this.CreateLoaningAccount(accountType, accountNumber);

                case AccountCatagoryEnum.Saving:
                    return this.CreateSavingAccount(accountType, accountNumber);

                default: 
                    throw new Exception("The account can only be Saving or Loaning account, Please specify valid acount account category");
            }
        }

        public override ILoaningAccount CreateLoaningAccount(AccountTypeEnum accountType, string accountNumber)
        {
            ILoaningAccountFactory factory = new LoaningAccountFactory();

            return factory.CreateAccount(accountType: accountType
                , accountNumber: accountNumber);
        }

        public override ISavingAccount CreateSavingAccount(AccountTypeEnum accountType, string accountNumber)
        {
            ISavingAccountFactory factory = new SavingAccountFactory();

            return factory.CreateAccount(accountType: accountType
                , accountNumber: accountNumber);
        }
    }
}