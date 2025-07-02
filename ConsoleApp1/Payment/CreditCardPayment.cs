using System.Text;

namespace ConsoleApp1.Payment
{
    public class CreditCardPayment : IPaymentDetails, IPaymentProcessor
    {
        private int id;
        private decimal amount;
        private string creditCardNumber;

        private static int lastTransId = 0;

        public CreditCardPayment(decimal amount , string cardNumber)
        {
            ValidateCardNumber(cardNumber);
            this.amount = amount;
            creditCardNumber = cardNumber;
            id = GenereateTransId();
        }

        public void DisplayPaymentDetails()
        {
            Console.WriteLine($"Payment ID: {id}");
            Console.WriteLine($"Payment amount: {amount}");
            Console.WriteLine($"Payment card number: {GetMaskedCardNumber()}");
        }

        public void ProcessPayment()
        {
            Console.WriteLine($"Process credit card payment of {amount:C2} with card: {GetMaskedCardNumber()}");
            Thread.Sleep(1000);
            Console.WriteLine("Credit card payment processed successfuly!");
        }

        private int GenereateTransId()
        {
            return ++lastTransId;
        }

        private void ValidateCardNumber(string cardNumber)
        {
            if (cardNumber.Length < 16)
            {
                throw new ArgumentException("Invali card lengh");
            }
        }

        private string GetMaskedCardNumber()
        {
            var sbt = new StringBuilder(creditCardNumber.Substring(0, 12));
            sbt.Append("****");
            return sbt.ToString();
        }
    }
}
