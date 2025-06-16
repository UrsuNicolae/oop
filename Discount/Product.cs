namespace ConsoleApp1.Discount
{
    class Product
    {
        private decimal? OldPrice = null;
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsDiscounted { get; set; }
        public double DiscounatRate { get; set; }


        public void ApplyDiscount(double discountRate)
        {
            if (!IsDiscounted)
            {
                OldPrice = Price;
                DiscounatRate = discountRate;
                Price = Price * (1 - (decimal)discountRate);
                IsDiscounted = true;
            }
        }

        public void RemoveDiscount()
        {

            if (IsDiscounted)
            {
                OldPrice = Price;
                Price = Price / (1 - (decimal)DiscounatRate);
                DiscounatRate = 0;
                IsDiscounted = false;
            }
        }

        public override string ToString()
        {
            return $"{Name}: {Price:C} \n Old:{OldPrice??Price:c}";
        }
    }
}
