namespace ConsoleApp1.SOLID.OrderProcesing
{
    class OrderValidator : IOrderValidator
    {
        public bool Validate(Order order)
        {
            if(order == null)
            {
                throw new ArgumentNullException("Invalid order.");
            }

            if(order.OrderAmount < 0)
            {
                return false;
            }

            if(order.OrderId < 0)
            {
                throw new ArgumentException($"Invalid order id: {order.OrderId}");
            }

            return true;
        }
    }

    class OrderPyamentProcessor : IOrderPaymentProcesor
    {
        public void ProcessPayment(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException("Invalid order.");
            }
            if (order.OrderAmount < 0)
            {
                throw new ArgumentException($"Invalid order amount: {order.OrderAmount}");
            }
            Console.WriteLine($"Process payment for order: {order.OrderId} for sum: {order.OrderAmount}");
        }
    }

    class InvoiceGenerator : IInvoiceGenerator
    {
        public void GenerateInvoice(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException("Invalid order.");
            }
             
            if (order.OrderAmount < 0)
            {
                throw new ArgumentException($"Invalid order amount: {order.OrderAmount}");
            }
            Console.WriteLine($"Invoice for order: {order.OrderId} is: {order.OrderAmount}");
        }
    }

    class OrderNotificationSerive : IOrderNotificationService
    {
        public void Notify(Order order)
        {
            Console.WriteLine($"Send notiication for order: {order.OrderId} with customer: {order.CustomerName}");
        }
    }
}
