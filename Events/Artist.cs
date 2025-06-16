using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;

namespace ConsoleApp1.Events
{
    abstract class Artist
    {
        public string Name { get; }
        public string Genu { get; }

        protected Artist(string name, string genu)
        {
            Name = name;
            Genu = genu;
        }

        public abstract void DisplayDetails();
    }

    class SoloMusician : Artist
    {
        public string Instrument { get; }
        public SoloMusician(string name, string genu, string instrument) : base(name, genu)
        {
            Instrument = instrument;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Solo musician: {Name}, Genre: {Genu}, Instrument: {Instrument}");
        }
    }

    class Band : Artist
    {
        public int NumberOfMembers { get; }
        public Band(string name, string genu, int numberOfMembers) : base(name, genu)
        {
            NumberOfMembers = numberOfMembers;
        }

        public override void DisplayDetails()
        {

            Console.WriteLine($"Band: {Name}, Genre: {Genu}, With: {NumberOfMembers} members");
        }
    }

    class DJ : Artist
    {
        public string Style { get; }


        public DJ(string name, string genu, string style) : base(name, genu)
        {
            Style = style;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"DJ: {Name}, Genre: {Genu}, Sytle: {Style}");
        }
    }
}
