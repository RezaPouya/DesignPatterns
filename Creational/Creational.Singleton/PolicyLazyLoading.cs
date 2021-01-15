namespace Creational.Singleton
{
    public sealed class PolicyLazyLoading
    {
        private static PolicyLazyLoading _instance = null;
        private static object lockObj = new object();

        /// <summary>
        /// for test purpose
        /// </summary>
        public static int Counter { get; private set; }

        // private constructor
        private PolicyLazyLoading()
        {
            Counter++;
        }

        public static PolicyLazyLoading GetInstance()
        {
            if (_instance == null)
            {
                lock (lockObj)
                {
                    if (_instance == null)
                        _instance = new PolicyLazyLoading();
                }
            }
            return _instance;
        }

        public string NationalId { get; private set; } = "9988776655";
        public string Fname { get; private set; } = "Reza";
        public string Lname { get; private set; } = "Pouya";
    }
}