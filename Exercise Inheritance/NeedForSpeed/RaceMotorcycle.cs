namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        public override double DefaultFuelConsumption => 8;
        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }
    }
}
