using Microsoft.Win32;
using OvningFem.Garages;
using OvningFem.Vehicles;

namespace Ovningfem.Controllers;

class Controller
{
    public static Vehicle VehicleCreator()
    {
        throw new NotImplementedException();
    }
    public static Garage GarageCreator()
    {
        while (true)
        {
            Console.Write("Ange önskad garagestorlek: ");
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice > 0) return new Garage(choice);
                Console.WriteLine("Garagestorlek måste vara större än 0");
            }
            catch (FormatException)
            {
                Console.WriteLine("FEL! ANGE TAL I INTEGERFORMAT");
            }
        }
    }
    public static Garage GarageCreator(int Size, Vehicle[] Storage)
    {
        return new Garage(Size, Storage);
    }

    public static Vehicle RegistryFind(Garage Storage)
    {
        Console.Write("Vänligen ange registreringsnummer: ");
        while (true)
        {
            string Registry = Console.ReadLine();
            if (!string.IsNullOrEmpty(Registry))
            {
                Registry = Registry.ToUpper();
                Vehicle Found = Storage.GetVehicleByRegistry(Registry);
                return Found;
            }
            else
            {
                Console.WriteLine("ANGE ETT GILTIGT REGISTRERINGSNUMMER");
            }
        }
        
        
    }

    public static bool VehicleAdd()
    {
        throw new NotImplementedException();
    }

    public static bool VehicleRemove()
    {
        throw new NotImplementedException();
    }

    public static bool VehicleSearch()
    {
        throw new NotImplementedException();
    }


}