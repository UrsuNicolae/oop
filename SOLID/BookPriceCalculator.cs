namespace ConsoleApp1.SOLID
{
    public interface IBookPriceCalculator
    {
        decimal CalcuateDiscount(Book book, decimal discountPercent);
    }
    public class BookPriceCalculator : IBookPriceCalculator
    {
        public decimal CalcuateDiscount(Book book, decimal discountPercent)
        {
            return book.Price - (book.Price * discountPercent) / 100;
        }
    }
}
