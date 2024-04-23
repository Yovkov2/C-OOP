namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        public override double DefaultFuelConsumption => 3;
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }
    }
}
