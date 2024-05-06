namespace Cars
{
    public class Car : ICar
    {
        public string Model { get; }

        public string Color { get; }
        public Car(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public void Start()
        {
            Console.WriteLine("Engine start...");
        }

        public void Stop()
        {
            Console.WriteLine($"Breaaak...");
        }
        public override string ToString()
        {
            return $"{Color} {Model}";
        }
    }
}