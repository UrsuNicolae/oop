namespace ConsoleApp1
{
    abstract class Document
    {
        private string content;

        protected Document(string content)
        {
            this.content = content;
        }

        public abstract void Open();

        public abstract void Save();


        public virtual void Print()
        {
            Console.WriteLine($"Document has connten:{content}");
        }
    }

    class WordDocument : Document
    {
        public WordDocument(string content) : base(content)
        {
        }

        public override void Open()
        {
            Console.WriteLine($"Open word document!");
        }

        public override void Save()
        {
            Console.WriteLine($"Save word document!");
        }

        public override void Print()
        {
            Console.WriteLine("This is a word document.");
            base.Print();
        }
    }


    class PdfDocument : Document
    {
        public PdfDocument(string content) : base(content)
        {
        }

        public override void Open()
        {
            Console.WriteLine($"Open pdf document!");
        }

        public override void Save()
        {
            Console.WriteLine($"Save pdf document!");
        }

        public override void Print()
        {
            Console.WriteLine("This is a pdf document.");
            base.Print();
        }
    }

}
