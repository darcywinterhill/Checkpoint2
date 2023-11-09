using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<Product> sortList()
        {
            return Products.OrderBy(product => product.Price).ToList();
        }

        //method to summarize product prices
        public int summarizeProducts()
        {
            return Products.Sum(product => product.Price);
        }

    }
}