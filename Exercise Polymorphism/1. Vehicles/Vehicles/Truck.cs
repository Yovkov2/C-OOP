using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double AirConditionerConsumption = 1.6;
        private const double RefuelEfficiency = 0.95;
        public Truck(double fuelQuantity, double fuelConsumptionPerKm)
                : base(fuelQuantity, fuelConsumptionPerKm + AirConditionerConsumption)
        {
        }

        public override void Drive(double distance)
        {
            double neededFuel = distance * FuelConsumptionPerKm;
            if (neededFuel <= FuelQuantity)
            {
                FuelQuantity -= neededFuel;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public override void Refuel(double liters)
        {
            FuelQuantity += liters * RefuelEfficiency;
        }
    }
}
