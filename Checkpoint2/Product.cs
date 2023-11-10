namespace Checkpoint2
{
    internal class Product
    {
        public Product(string category, string productName, int price)
        {
            Category = category;
            ProductName = productName;
            Price = price;
        }

        public string Category { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }


        public string Print()
        {
            return Category.PadRight(20) + ProductName.PadRight(20) + Price;
        }
    }
}