using System;

namespace Creational.Singleton
{
    public sealed class SingeltonTemplate
    {
        private static Lazy<SingeltonTemplate> _instance =
            new Lazy<SingeltonTemplate>(() => new SingeltonTemplate());

        private SingeltonTemplate()
        {
        }

        public static SingeltonTemplate GetInstance() => _instance.Value;

        // Properties and Method implemented here
    }
}