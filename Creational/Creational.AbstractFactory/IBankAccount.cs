using Creational.AbstractFactory.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.AbstractFactory
{
    public abstract class IBankAccount
    {
        public AccountTypeEnum AccountType { get; protected set; }
        public string AccountNumber { get; protected set; }
        public decimal Balance { get; protected set; }
    }
}
