using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.AbstractFactory
{
    public abstract class IBankAccount
    {
        public AccountType AccountType { get; protected set; }
        public string AccountNumber { get; protected set; }
        public decimal Balance { get; protected set; }
    }
}
