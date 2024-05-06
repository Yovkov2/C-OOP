namespace Cars
{
    public class ElectricCar : Car, ICar
    {
        public ElectricCar(string model, string color, int battery) : base(model, color)
        {
            Battery = battery;
        }
        public int Battery { get; set; }
        public override string ToString()
        {
            return $"{Color} {Model} with {Battery} Batteries";
        }
    }
}