namespace NeedForSpeed
{
    public class SportCar : Car
    {
        public override double DefaultFuelConsumption => 10;
        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }

    }
}
