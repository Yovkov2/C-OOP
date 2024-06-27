using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Product
    {
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public int Price { get; set; }
        public void IncreassePrice(int amount)
        {
            Price += amount;
            Console.WriteLine($"The price for the {Name} has been incressed by {amount}$.");
        }
        public void DecreassePrice(int amount)
        {
            if(amount < Price)
            {
                Price += amount;
                Console.WriteLine($"The price for the {Name} has been decreassed by {amount}$.");
            }
            
        }
        public override string ToString() => $"Current price for the {Name} product is {Price}$.";
    }
}
