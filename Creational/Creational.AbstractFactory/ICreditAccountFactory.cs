using Creational.AbstractFactory.Loaning;
using Creational.AbstractFactory.Saving;
using System;

namespace Creational.AbstractFactory
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    public abstract class ICreditAccountFactory
    {
        /// <summary>
        /// main method 
        /// </summary>s
        public abstract IBankAccount CreateAccount(AccountType accountType
            , string accountNumber
            , AccountCatagory accountCatagory);
        
        public abstract ILoaningAccount CreateLoaningAccount(AccountType accountType
            , string accountNumber);

        public abstract ISavingAccount CreateSavingAccount(AccountType accountType
            , string accountNumber);
    }
}