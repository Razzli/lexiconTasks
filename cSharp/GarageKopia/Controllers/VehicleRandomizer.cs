using GarageKopia.Vehicles;

namespace GarageKopia.Controllers;

class VehicleRandomizer
{
    private static string[] _colours = [
        "svart",
        "blå",
        "gul",
        "röd",
        "neongrön",
        "vit"
        ];
    private static Random Rand = new Random();
    public static Vehicle Create(List<Vehicle> Vehicles)
    {
        int Choice = Rand.Next(5);
        string Colour = _colours[Rand.Next(_colours.Length)];
        string Registry = RegistryCreator(Vehicles);
        Vehicle vehicle;
        switch (Choice)
        {
            case 0:
                vehicle = new Airplane(Colour, Rand.Next(10, 30), Registry, Rand.Next(30, 50), Rand.Next(2, 5));
                break;
            case 1:
                vehicle = new Boat(Colour, Rand.Next(2, 10), Registry, Rand.Next(5, 20), Rand.Next(1, 5));
                break;
            case 2:
                //Thank you https://stackoverflow.com/questions/19191058/fastest-way-to-generate-a-random-boolean
                vehicle = new Bus(Colour, Rand.Next(10, 20), Registry, Rand.NextDouble() >= 0.5, 6);
                break;
            case 3:
                vehicle = new Car(Colour, Rand.Next(4,6), Registry, Rand.NextDouble() >= 0.5);
                break;
            case 4:
                vehicle = new Motorcycle(Colour, Rand.Next(1, 3), Registry, Rand.NextDouble() >= 0.5);
                break;
            default:
                throw new Exception("Vehicle not created");
        }
        Console.WriteLine($"Du har skapat: {vehicle.ToString()}");
        return vehicle;
    }

    private static string RegistryCreator(List<Vehicle> Vehicles)
    {
        bool match = false;
        while (true)
        {
            string registry = Rand.GetString("abcdefghijklmnopqrstuvwxyz", 3);
            registry += Rand.Next(10);
            registry += Rand.Next(10);
            registry += Rand.Next(10);
            foreach (Vehicle item in Vehicles)
            {
                if (item.Registry == registry) match = true;
            }
            if (!match) return registry;
        }
    }
}