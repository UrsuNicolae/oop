using System.Text;

namespace ConsoleApp1.Payment
{
    public class PaypalPayment : IPaymentDetails, IPaymentProcessor
    {
        private int id;
        private decimal amount;
        private string accountEmail;

        private static int lastTransId = 0;

        public PaypalPayment(decimal amount , string emailAccount)
        {
            ValidateEmailAccount(emailAccount);
            this.amount = amount;
            this.accountEmail = emailAccount;
            id = GenereateTransId();
        }

        public void DisplayPaymentDetails()
        {
            Console.Write($"Payment ID: {id}");
            Console.Write($"Payment amount: {amount}");
            Console.Write($"Payment account: {accountEmail}");
        }

        public void ProcessPayment()
        {
            throw new Exception("Bad error");
            Console.WriteLine($"Process paypal card payment of {amount:C2}");
            Thread.Sleep(1000);
            Console.WriteLine("Paypal payment processed successfuly!");
        }

        private int GenereateTransId()
        {
            return ++lastTransId;
        }

        private void ValidateEmailAccount(string email)
        {
            if (!email.Contains("@"))
            {
                throw new ArgumentException("Invali email");
            }

            if (email.Length < 10)
            {
                throw new ArgumentException("Invali email lengh");
            }
        }
    }
}
