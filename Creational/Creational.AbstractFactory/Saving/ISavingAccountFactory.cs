using Creational.AbstractFactory.Enums;

namespace Creational.AbstractFactory.Saving
{
    /// <summary>
    /// Creator
    /// </summary>
    public interface ISavingAccountFactory
    {
        ISavingAccount CreateAccount(AccountTypeEnum accountType, string accountNumber);
    }
}