namespace Vehicles
{
    public abstract class Vehicle
    {
        public double FuelQuantity { get; protected set; }
        public double FuelConsumptionPerKm { get; protected set; }
        protected Vehicle(double fuelQuantity, double fuelConsumptionPerKm)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
        }
        public abstract void Drive(double distance);
        public abstract void Refuel(double liters);
    }
}
