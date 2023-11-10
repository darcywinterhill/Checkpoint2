namespace Checkpoint2

//Holds a list with all products
{
    internal class Inventory
    {
        public List<Product> Products { get; set; }

        public Inventory()
        {
            Products = new List<Product>();
        }

        //method to sort list by price, low - high
        public List<Product> SortList()
        {
            return Products.OrderBy(product => product.Price).ToList();
        }

        //method to summarize product prices
        public int SummarizeProducts()
        {
            return Products.Sum(product => product.Price);
        }

    }
}