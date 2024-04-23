using System;

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
}
