using Command;
using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product("Phone", 500);
            var modifyPrice = new ModifyPrice();

            Execute(modifyPrice, new ProductCommand(product, PriceAction.Increase, 100));
            Execute(modifyPrice, new ProductCommand(product, PriceAction.Decrease, 50));
            Execute(modifyPrice, new ProductCommand(product, PriceAction.Increase, 200));

            Console.WriteLine(product.Name);

            Console.WriteLine($"Final price of the {product.Name} is {product.Price:C}");
        }

        private static void Execute(ModifyPrice modifyPrice, ICommand command)
        {
            modifyPrice.SetCommand(command);
            modifyPrice.Invoke();
        }
    }
}