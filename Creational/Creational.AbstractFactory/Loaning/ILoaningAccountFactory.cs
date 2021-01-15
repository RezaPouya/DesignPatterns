using Creational.AbstractFactory.Enums;
using System.Collections.Generic;
using System.Text;

namespace Creational.AbstractFactory.Loaning
{
    public interface ILoaningAccountFactory
    {
        ILoaningAccount CreateAccount(AccountTypeEnum accountType, string accountNumber);
    }
}
