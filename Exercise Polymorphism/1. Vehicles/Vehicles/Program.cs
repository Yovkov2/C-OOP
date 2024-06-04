using Vehicles;

string[] carInfo = Console.ReadLine().Split();
string[] truckInfo = Console.ReadLine().Split();

Car car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
Truck truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

int commandCount = int.Parse(Console.ReadLine());
for (int i = 0; i < commandCount; i++)
{
    string[] commandParts = Console.ReadLine().Split();
    string action = commandParts[0];
    string vehicleType = commandParts[1];

    if (action == "Drive")
    {
        double distance = double.Parse(commandParts[2]);
        if (vehicleType == "Car")
        {
            car.Drive(distance);
        }
        else if (vehicleType == "Truck")
        {
            truck.Drive(distance);
        }
    }
    else if (action == "Refuel")
    {
        double liters = double.Parse(commandParts[2]);
        if (vehicleType == "Car")
        {
            car.Refuel(liters);
        }
        else if (vehicleType == "Truck")
        {
            truck.Refuel(liters);
        }
    }
}

Console.WriteLine($"Car: {car.FuelQuantity:F2}");
Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");