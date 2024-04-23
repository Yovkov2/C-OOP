using System;

namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Beverage beverage = new Beverage("Cola", 2.5m, 330);
            Console.WriteLine($"Beverage: {beverage.Name}, Price: {beverage.Price}, Milliliters: {beverage.Milliliters}");
            Cake cake = new Cake("Chocolate Cake");
            Console.WriteLine($"Cake: {cake.Name}, Price: {cake.Price}, Grams: {cake.Grams}, Calories: {cake.Calories}");
        }
    }
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
    public class Beverage : Product
    {
        public double Milliliters { get; set; }
        public Beverage(string name, decimal price, double milliliters) : base(name, price)
        {
            Milliliters = milliliters;
        }
    }
    public class HotBeverage : Beverage
    {
        public HotBeverage(string name, decimal price, double milliliters) : base(name, price, milliliters)
        {
        } 
    }
    public class ColdBeverage : Beverage
    {
        public ColdBeverage(string name, decimal price, double milliliters) : base(name, price, milliliters)
        {
        }
    }
    public class Coffe : HotBeverage
    {
        public double CoffeeMilliliters { get; } = 50;
        public decimal CoffeePrice { get; } = 3.50m;
        public double Caffeine { get; } = 50;
        public Coffe(string name, decimal price, double milliliters, double caffeine) : base(name, price, milliliters)
        {
            Caffeine = caffeine;
        }
    }
    public class Tea : HotBeverage
    {
        public Tea(string name, decimal price, double milliliters) : base(name, price, milliliters)
        {
        }
    }
    public class Food : Product
    {
        public double Grams { get; set; }
        public Food(string name, decimal price, double grams) : base(name, price)
        {
            Grams = grams;
        }
    }
    public class MainDish : Food
    {
        public MainDish(string name, decimal price, double grams) : base(name, price, grams)
        {
        }
    }
    public class Dessert : Food
    {
        public double Calories { get; set; }
        public Dessert(string name, decimal price, double grams, double calories) : base(name, price, grams)
        {
            Calories = calories;
        }
    }
    public class Starter : Food
    {
        public Starter(string name, decimal price, double grams) : base(name, price, grams)
        {
        }
    }
    public class Fish : MainDish
    {
        public Fish(string name, decimal price, double grams) : base(name, price, 22)
        {
        }
    }
    public class Soup : Starter
    {
        public Soup(string name, decimal price, double grams) : base(name, price, grams)
        {
        }
    }
    public class Cake : Dessert
    {
        public double CakePrice { get; } = 5;
        public double DefaultGrams { get; } = 250;
        public double DefaultCalories { get; } = 1000;

        public Cake(string name) : base(name, 5, 250, 1000)
        {
        }
    }

}