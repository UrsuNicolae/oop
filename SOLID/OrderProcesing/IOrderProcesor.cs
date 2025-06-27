namespace ConsoleApp1.SOLID.OrderProcesing
{
    interface IOrderValidator
    {
        bool Validate(Order order);
    }

    interface IOrderPaymentProcesor
    {
        void ProcessPayment(Order order);
    }

    interface IOrderNotificationService
    {
        void Notify(Order order);
    }

    interface IInvoiceGenerator
    {
        void GenerateInvoice(Order order);
    }
}
