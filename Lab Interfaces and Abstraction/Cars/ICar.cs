namespace Cars
{
    public interface ICar
    {
        string Model { get; }
        string Color { get; }
        void Start();
        void Stop();
    }
}