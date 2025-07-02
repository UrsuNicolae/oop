namespace ConsoleApp1.SOLID
{
    public class Library
    {
        private readonly IBookPriceCalculator priceCalculator;
        private readonly IBookRepository bookRepository;

        public Library(IBookPriceCalculator priceCalculator, IBookRepository bookRepository)
        {
            this.priceCalculator = priceCalculator;
            this.bookRepository = bookRepository;
        }

        public void DisplayBooks()
        {
            foreach (var book in bookRepository.LoadAll())
            {
                Console.WriteLine(book);
            }
        }

        public void GiveDiscount(string isbn, decimal dicount)
        {
            var book = bookRepository.Load(isbn);
            if(book != null)
            {
                book.Price = priceCalculator.CalcuateDiscount(book, 12);
                bookRepository.Save(book);
            }
        }

        public void AddNewBook(string isbn, string author, string title, decimal price)
        {
            var book = new Book
            {
                ISBN = isbn,
                Author = author,
                Title = title,
                Price = price
            };
            bookRepository.Save(book);
        }
    }
}
