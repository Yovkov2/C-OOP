using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double AirConditionerConsumption = 0.9;
        public Car(double fuelQuantity, double fuelConsumptionPerKm)
               : base(fuelQuantity, fuelConsumptionPerKm + AirConditionerConsumption)
        {
        }
        public override void Drive(double distance)
        {
            double neededFuel = distance * FuelConsumptionPerKm;
            if (neededFuel <= FuelQuantity)
            {
                FuelQuantity -= neededFuel;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }

        public override void Refuel(double liters)
        {
            FuelQuantity += liters;
        }
    }
}
