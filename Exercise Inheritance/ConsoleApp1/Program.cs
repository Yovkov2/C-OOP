using System;

namespace NeedForSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of different vehicles
            Car car = new Car(200, 50);
            SportCar sportCar = new SportCar(300, 50);
            FamilyCar familyCar = new FamilyCar(150, 50);
            Motorcycle motorcycle = new Motorcycle(100, 30);
            RaceMotorcycle raceMotorcycle = new RaceMotorcycle(150, 30);
            CrossMotorcycle crossMotorcycle = new CrossMotorcycle(120, 30);

            // Test driving each vehicle
            car.Drive(100);
            sportCar.Drive(100);
            familyCar.Drive(100);
            motorcycle.Drive(100);
            raceMotorcycle.Drive(100);
            crossMotorcycle.Drive(100);
        }
    }
}

namespace NeedForSpeed
{
    public class Vehicle
    {
        public virtual double DefaultFuelConsumption => 1.25;

        private int horsePower;
        private double fuel;

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }

        public double Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

        public int HorsePower
        {
            get { return horsePower; }
            set { horsePower = value; }
        }

        public virtual double FuelConsumption => DefaultFuelConsumption;

        public virtual void Drive(double kilometers)
        {
            double fuelUsed = kilometers * FuelConsumption;
            if (Fuel >= fuelUsed)
            {
                Fuel -= fuelUsed;
                Console.WriteLine($"Traveled {kilometers} kilometers. Remaining fuel: {Fuel} liters.");
            }
            else
            {
                Console.WriteLine("Not enough fuel to complete the journey.");
            }
        }
    }

    public class Car : Vehicle
    {
        public override double DefaultFuelConsumption => 3;

        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }
    }

    public class SportCar : Car
    {
        public override double DefaultFuelConsumption => 10;

        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }
    }

    public class RaceMotorcycle : Motorcycle
    {
        public override double DefaultFuelConsumption => 8;

        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }
    }

    public class Motorcycle : Vehicle
    {
        public Motorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }
    }

    public class FamilyCar : Car
    {
        public FamilyCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }
    }

    public class CrossMotorcycle : Motorcycle
    {
        public CrossMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }
    }
}