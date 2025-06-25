namespace ConsoleApp1.SOLID
{
    public interface IBookRepository
    {
        void Save(Book book);

        Book Load(string isbn);

        List<Book> LoadAll();
    }

    public class BookRepository : IBookRepository
    {
        private List<Book> books = new();
        public Book Load(string isbn)
        {
            Console.WriteLine($"Check for isbn: {isbn}");
            Console.WriteLine($"Loading book details!");
            return books.FirstOrDefault(b => b.ISBN == isbn);
        }

        public List<Book> LoadAll()
        {
            return books;
        }

        public void Save(Book book)
        {
            var existingBook = books.FirstOrDefault(b => b.ISBN == book.ISBN);
            if (existingBook == null)
            {
                Console.WriteLine($"Saving book: {book}");
                books.Add(book);
            }
            else
            {
                Console.WriteLine($"Update book: {book}");
                existingBook.Author = book.Author;
                existingBook.Price = book.Price;
                existingBook.Title = book.Title;
            }
        }
    }
}
