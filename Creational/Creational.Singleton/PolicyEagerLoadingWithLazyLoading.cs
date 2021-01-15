using System;

namespace Creational.Singleton
{
    /// <summary>
    /// Sealed keyword restrict inheritance
    /// </summary>
    public sealed class PolicyEagerLoadingWithLazyLoading
    {
        // to make it thread safe
        private static readonly Lazy<PolicyEagerLoadingWithLazyLoading> _instance = 
            new Lazy<PolicyEagerLoadingWithLazyLoading>(
                () => new PolicyEagerLoadingWithLazyLoading()
            );

        /// <summary>
        /// for test purpose
        /// </summary>
        public static int Counter { get; private set; }

        // private constructor
        private PolicyEagerLoadingWithLazyLoading()
        {
            Counter++;
        }

        public static PolicyEagerLoadingWithLazyLoading GetInstance() => _instance.Value;

        public string NationalId { get; private set; } = "9988776655";
        public string Fname { get; private set; } = "Reza";
        public string Lname { get; private set; } = "Pouya";
    }
}