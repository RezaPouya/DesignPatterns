namespace Creational.Factory.ConcreteContracts
{
    // Product
    public abstract class ISavingAccount
    {
       
        public AccountTypeEnum AccountType { get; protected set; }
        public string AccountNumber { get; protected set; }
        public decimal Balance { get; protected set; }
    }
}