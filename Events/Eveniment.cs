namespace ConsoleApp1.Events
{
    abstract class Eveniment
    {
        public string Location { get; }
        public DateTime Date{ get; }

        protected Eveniment(string location, DateTime date)
        {
            Location = location;
            Date = date;
        }

        public abstract void DisplayDetails();
    }

    class MainConcert : Eveniment
    {
        public Artist MainArtist { get; }
        public MainConcert(string location, DateTime date, Artist mainArtist) : base(location, date)
        {
            MainArtist = mainArtist;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Main event: {Location}, Date: {Date:yyyy:MM:dd}");
            MainArtist.DisplayDetails();
        }
    }

    class AcusticSession : Eveniment
    {
        public Artist AcusticArtist { get; }
        public AcusticSession(string location, DateTime date, Artist acusticArtist) : base(location, date)
        {
            AcusticArtist = acusticArtist;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Acusting event: {Location}, Date: {Date:yyyy:MM:dd}");
            AcusticArtist.DisplayDetails();
        }
    }

    class AfterParty : Eveniment
    {
        public Artist Dj { get; }
        public AfterParty(string location, DateTime date, Artist dj) : base(location, date)
        {
            Dj = dj;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"AfterParty event: {Location}, Date: {Date:yyyy:MM:dd}");
            Dj.DisplayDetails();
        }
    }
}
