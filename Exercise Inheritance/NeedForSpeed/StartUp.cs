using System.Reflection.Metadata;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Car car = new Car(200, 50);
            SportCar sportCar = new SportCar(300, 50);
            FamilyCar familyCar = new FamilyCar(150, 50);
            Motorcycle motorcycle = new Motorcycle(100, 30);
            RaceMotorcycle raceMotorcycle = new RaceMotorcycle(150, 30);
            CrossMotorcycle crossMotorcycle = new CrossMotorcycle(120, 30);

            
            car.Drive(100);
            sportCar.Drive(100);
            familyCar.Drive(100);
            motorcycle.Drive(100);
            raceMotorcycle.Drive(100);
            crossMotorcycle.Drive(100);
        }
    }
}
