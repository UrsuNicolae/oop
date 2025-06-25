namespace ConsoleApp1.SOLID
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public string ISBN { get; set; }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, Price: {Price:C}, ISBN: {ISBN}";
        }
    }
}
