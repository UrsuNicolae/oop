using ConsoleApp1.Logging;
using System.Diagnostics;

namespace ConsoleApp1.Payment
{
    public class PaymentManager
    {
        private readonly ILogger logger;

        public PaymentManager(ILogger logger)
        {
            this.logger = logger;
        }
        public void Process(IPaymentProcessor processor)
        {
            try
            {
                logger.LogInformation("Manager received payment for processing!");
                processor.ProcessPayment();
                logger.LogInformation("Manager processed the payment!");
            }
            catch (Exception e)
            {
                logger.LogError(e.Message);
            }
        }

        public void DisplayTransDetails(IPaymentDetails paymentDetails)
        {
            try
            {
                logger.LogInformation("Manager received payment for display!");
                paymentDetails.DisplayPaymentDetails();
            }
            catch (Exception e)
            {
                logger.LogError(e.Message);
            }
        }
    }
}
