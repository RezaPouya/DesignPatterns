namespace Structural.Bridge
{
    public class MellatPaymentSystem : IPaymentSystem
    {
        public string message { get; set; }

        public void ProcessPayment(string paymentMethod)
        {
            message = $"The {paymentMethod} payment is Done with Mellat Payment System";
        }
    }
}