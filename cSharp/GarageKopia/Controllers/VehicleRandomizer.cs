using GarageKopia.Vehicles;

namespace GarageKopia.Controllers;

class VehicleRandomizer
{
    private string[] _colours = [
        "svart",
        "blå",
        "gul",
        "röd",
        "neongrön",
        "vit"
        ];
    private Random Rand = new Random();
    public Vehicle Create(List<Vehicle> Vehicles)
    {
        int Choice = Rand.Next(5);
        string Colour = _colours[Rand.Next(_colours.Length)];
        string Registry = RegistryCreator(Vehicles);
        switch (Choice)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            default:
                break;
        }
    }

    private string RegistryCreator(List<Vehicle> Vehicles)
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