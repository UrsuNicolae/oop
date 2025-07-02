namespace ConsoleApp1.SOLID.OrderProcesing
{
    class OrderManager
    {
        private readonly IOrderValidator validator;
        private readonly IOrderPaymentProcesor paymentProcesor;
        private readonly IOrderNotificationService notificationService;
        private readonly IInvoiceGenerator invoiceGenerator;

        public OrderManager(IOrderValidator validator,
            IOrderPaymentProcesor paymentProcesor,
            IOrderNotificationService notificationService,
            IInvoiceGenerator invoiceGenerator)
        {
            this.validator = validator;
            this.paymentProcesor = paymentProcesor;
            this.notificationService = notificationService;
            this.invoiceGenerator = invoiceGenerator;
        }

        public void HandleOrder(Order order)
        {
            if(validator.Validate(order))
            {
                paymentProcesor.ProcessPayment(order);
                invoiceGenerator.GenerateInvoice(order);
                notificationService.Notify(order);
            }
        }
    }
}
