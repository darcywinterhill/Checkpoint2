using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint2
{
    internal class Product
    {
        public string Category {  get; set; }
        public string ProductName {  get; set; }
        public int Price {  get; set; }

        public string Print()
        {
            return Category.PadRight(10) + ProductName.PadRight(10) + Price;
        }
    }

}
