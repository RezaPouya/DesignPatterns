using System;

namespace  Creational.AbstractFactory.Saving
{
    /// <summary>
    /// Creator
    /// </summary>
    public interface ISavingAccountFactory
    {
        ISavingAccount CreateAccount(AccountType accountType, string accountNumber);
    }

    public class SavingAccountFactory : ISavingAccountFactory
    {
        public ISavingAccount CreateAccount(AccountType accountType, string accountNumber)
        {
            if (string.IsNullOrEmpty(accountNumber))
                throw new Exception("The account number cannot be null");

            switch (accountType)
            {
                case AccountType.NA: throw new Exception("The Account can only be Personal or Company Account , Please specify acount type ");
                case AccountType.Personal: return new PersonalSavingAccount(accountNumber);
                case AccountType.Company: return new CompanySavingAccount(accountNumber);
                default: throw new Exception("The Account can only be Personal or Company Account , Please specify acount type ");
            }
        }
    }
}