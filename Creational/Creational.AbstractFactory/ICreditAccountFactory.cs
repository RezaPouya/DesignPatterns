using Creational.AbstractFactory.Enums;
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
        public abstract IBankAccount CreateAccount(AccountTypeEnum accountType
            , string accountNumber
            , AccountCatagoryEnum accountCatagory);
        
        public abstract ILoaningAccount CreateLoaningAccount(AccountTypeEnum accountType
            , string accountNumber);

        public abstract ISavingAccount CreateSavingAccount(AccountTypeEnum accountType
            , string accountNumber);
    }
}