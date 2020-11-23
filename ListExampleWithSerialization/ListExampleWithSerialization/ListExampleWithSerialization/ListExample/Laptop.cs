using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    [Serializable]
    class Laptop
    {
        public Laptop(double screenSize, double price, string brand)
        {
            ScreenSize = screenSize;
            Price = price;
            Brand = brand;
        }

        private double ScreenSize { get; set; }
        private double Price { get; set; }
        private string Brand { get; set; }
    }
}
