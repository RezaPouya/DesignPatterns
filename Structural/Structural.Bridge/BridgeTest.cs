using System;
using Xunit;

namespace Structural.Bridge
{
    public class BridgeTest
    {
        [Fact]
        public void Should_Pass_If_Can_Create_Sadad_Payment_System()
        {
            // Arrange
            Payment payment = GetPayment("Online");
            payment.PaymentSystem = GetPaymentSytem("Sadad");

            // Act
            payment.MakePayment();

            // Assert
            Assert.Equal("The Online payment is done via Sadad payment system", payment.PaymentSystem.message);

        }

        private Payment GetPayment(string payment)
        {
            switch (payment)
            {
                case "Online":
                    return new OnlinePayment();

                case "PcPos":
                    return new PcPosPayment();

                default:
                    throw new Exception("The Payment method is not supported");
            }
        }

        private IPaymentSystem GetPaymentSytem(string paymentSystem)
        {
            switch (paymentSystem)
            {
                case "Sadad":
                    return new SadadPaymentSystem();

                case "Mellat":
                    return new MellatPaymentSystem();

                default:
                    throw new Exception("The payment system is not supported");
            }
        }
    }
}