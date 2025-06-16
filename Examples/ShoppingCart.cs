namespace ConsoleApp1.Examples
{
    internal class ShoppingCart
    {
        private List<string> produse;


        public ShoppingCart()
        {
            produse = new List<string>();
        }


        public void AdaugaProduse(string produsSpreAdaugare, int nr)
        {
            produse.Add(produsSpreAdaugare);
        }


        public void AdaugaProduse(string produs1, string produs2)
        {
            produse.Add(produs1);
            produse.Add(produs2);
        }


        public int AdaugaProduse(string produs3)
        {
            produse.Add(produs3);
            return produse.Count();
        }


        public void AdaugaProduse(List<string> produseSpreAdaugare)
        {
            produse.AddRange(produseSpreAdaugare);
        }


        public void AdaugaProduse( string[] produseSpreAdaugare)
        {
            produse.AddRange(produseSpreAdaugare);
        }
    }
}


