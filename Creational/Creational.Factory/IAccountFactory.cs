using Creational.Factory.ConcreteContracts;

namespace Creational.Factory
{
    /// <summary>
    /// Creator
    /// </summary>
    public interface IAccountFactory
    {
        ISavingAccount GetSavingAccount(AccountTypeEnum accountType, string accountNumber);
    }
}