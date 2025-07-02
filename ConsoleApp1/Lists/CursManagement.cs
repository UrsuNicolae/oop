using System.Collections;
using System.Reflection;

namespace ConsoleApp1.Lists
{
    public class Curs
    {
        public string Name { get; set; }
        public int Durata { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"{Name} : {Date}";
        }
    }
    public class CursManagement
    {
        private ArrayList cursuri = new ArrayList();
        private Hashtable sali = new Hashtable();
        private SortedList orarSapatamanal = new SortedList();
        private Stack changes = new Stack();
        private Queue next = new Queue();

        public void Gestiune()
        {
            while (true)
            {
                var optiune = Console.ReadLine();
                switch (optiune)
                {
                    case "1":
                        AdaugaCurs();
                        break;
                    case "2":
                        AfiseazaOrar();
                        break;
                    case "3":
                        ShowNext();
                        break;
                    case "4":
                        StergeCurs();
                        break;
                    case "5":
                        ShowChanges();
                        break;
                    case "0":
                    default:
                        return;
                }
            }
        }

        private void AfiseazaOrar()
        {
            if (orarSapatamanal.Count == 0)
            {
                Console.WriteLine("Orarul este gol");
            }
            else
            {
                foreach (DictionaryEntry zi in orarSapatamanal)
                {
                    foreach(var curs in (ArrayList)zi.Value)
                    {
                        Console.WriteLine(curs);
                    }
                }
            }
        }

        private void ShowChanges()
        {
            foreach(var change in changes)
            {
                Console.WriteLine(change);
            }
        }

        private void ShowNext()
        {
            if(next.Count == 0)
            {
                Console.WriteLine("Nu avem cursuri urmatoare!");
            }
            var urmatoru = (Curs)next.Peek();
            Console.WriteLine(urmatoru);
            Console.WriteLine($"Sala: {sali[urmatoru.Name]}");
        }

        private void StergeCurs()
        {
            Console.WriteLine("Indica cursul care doresti sa il stergi!");
            string name = Console.ReadLine();
            var curs = cursuri.Cast<Curs>().FirstOrDefault(c => c.Name == name);
            if(curs == null)
            {
                Console.WriteLine("Cursul nu exista!");
            }
            cursuri.Remove(curs);
            sali.Remove(curs);
            foreach (DictionaryEntry zi in orarSapatamanal)
            {
                var listaCursuri = (ArrayList)zi.Value;
                if (listaCursuri.Contains(name))
                {
                    listaCursuri.Remove(name);
                    return;
                }
            }
        }

        private void AdaugaCurs()
        {
            Console.WriteLine("Introduceti datele cursului:");
            string name = Console.ReadLine();
            if (cursuri.Cast<Curs>().Any(c => c.Name == name))
            {
                Console.WriteLine("Cursul deja exista");
                return;
            }

            var durata = int.Parse(Console.ReadLine());
            var date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti sala de curs");
            string sala = Console.ReadLine();
            if (sali.ContainsValue(sala))
            {
                Console.WriteLine("Sala este rezervata deja");
                return;
            }

            var curs = new Curs
            {
                Name = name,
                Date = date,
                Durata = durata
            };
            cursuri.Add(curs);

            next.Enqueue(curs);

            string ziua = date.ToString("dddd");
            if (!orarSapatamanal.ContainsKey(ziua))
            {
                orarSapatamanal.Add(ziua, new ArrayList());
            }

            ((ArrayList)orarSapatamanal[ziua]).Add(name);

            changes.Push($"Adaugat: {name} - {DateTime.Now}");
            Console.WriteLine("Cursul a fost adaugat cu success!");
        }
    }
}
