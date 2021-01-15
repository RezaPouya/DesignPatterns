namespace Creational.Singleton
{
    /// <summary>
    /// Sealed keyword restrict inheritance
    /// </summary>
    public sealed class PolicyEagerLoading
    {
        // to make it thread safe
        private static readonly PolicyEagerLoading _instance = new PolicyEagerLoading();

        /// <summary>
        /// for test purpose
        /// </summary>
        public static int Counter { get; private set; }

        // private constructor
        private PolicyEagerLoading()
        {
            Counter++;
        }

        public static PolicyEagerLoading GetInstance() => _instance;

        public string NationalId { get; private set; } = "9988776655";
        public string Fname { get; private set; } = "Reza";
        public string Lname { get; private set; } = "Pouya";
    }
}