using GarageKopia.Garages;
using GarageKopia.Vehicles;

namespace GarageKopia.Controllers;

class Controller
{
    public static Garage EmptyGarageCreator()
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
    public static Garage GarageCreator()
    {
        while (true){
            try
            {
                Console.Write("Ange önskad storlek på garaget: ");
                int Size = Convert.ToInt32(Console.ReadLine());
                if (Size < 1) Console.WriteLine("STORLEK MÅSTE VARA STÖRRE ÄN 0");
                else
                {
                    Console.Write("Ange antal fordon du vill skapa: ");
                    int Amount = Convert.ToInt32(Console.ReadLine());
                    if (Amount > Size) Console.WriteLine("DU KAN INTE SKAPA FLER FORDON ÄN PLATSER");
                    else if (Amount <= 0) Console.WriteLine("SKAPA ÅTMINSTONE 1 FORDON");
                    else
                    {
                        List<Vehicle> Vehicles = new List<Vehicle>();
                        for (int i = 0; i < Amount; i++)
                        {
                            Vehicles.Add(VehicleCreator.Create(Vehicles));
                        }
                        return new Garage(Size, Vehicles);
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("ANGE ETT GILTIGT INTEGERTAL");
            }
        }
        
    }

    public static Vehicle RegistryFind(Garage Storage)
    {
        Console.Write("Vänligen ange registreringsnummer: ");
        while (true)
        {
            string Registry = Console.ReadLine();
            if (!string.IsNullOrEmpty(Registry))
            {
                Registry = Registry.ToLower();
                Vehicle Found = Storage.GetVehicleByRegistry(Registry);
                return Found;
            }
            else
            {
                Console.WriteLine("ANGE ETT GILTIGT REGISTRERINGSNUMMER");
            }
        }
    }

    public static void VehicleAdd(Garage Storage)
    {
        if (Storage.GetFreeSpace() == 0) Console.WriteLine("GARAGE FULLT!");
        else
        {
            Storage.AddVehicle(VehicleCreator.Create(Storage.GetStorage()));
        }
    }

    public static void VehicleRemove(Garage Storage)
    {
        bool Running = true;
        while (Running)
        {
            int size = Storage.GetUsedSpace();
            if (size != 0)
            {
                try
                {
                    Console.Write($"Välj fordon 1-{size}");
                    int index = Convert.ToInt32(Console.ReadLine());
                    if (index > size) Console.WriteLine("Givet tal är för stort");
                    if (index < 1) Console.WriteLine("Givet tal är för litet");
                    else
                    {
                        Storage.RemoveVehicle(index-1);
                        Running = false;
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Given input måste vara integer!");
                }
                
            }
            else
            {
                Console.WriteLine("DET FINNS INGA FORDON ATT TA BORT");
                Running = false;
            }
            
        }
        
    }

    public static bool VehicleSearch(Garage Storage)
    {
        while (true)
        {
            Console.WriteLine("SÖKFUNKTION (LÄMNA BLANKT FÖR ATT INTE SÖKA PÅ EGENSKAP)");
            Console.Write("Ange färg: ");
            string inputC = Console.ReadLine();
            Console.Write("Ange sätesantal: ");
            string inputS = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputC) && string.IsNullOrWhiteSpace(inputS)) Console.WriteLine("ANGE ÅTMINSTONE EN EGENSKAP");
            else
            {
                List<Vehicle> Vehicles = Storage.GetStorage();
                bool found = false;
                if (string.IsNullOrWhiteSpace(inputS))
                {
                    inputC = inputC.ToLower();
                    for (int i = 0; i < Vehicles.Count; i++)
                    {
                        if (Vehicles[i].Colour == inputC) Console.WriteLine($"{i}. {Vehicles[i].ToString()}");
                        found = true;
                    }
                    if (!found) Console.WriteLine("INGA FORDON HITTADES");
                    return true;
                }
                else
                {
                    try
                    {
                        int Seats = Convert.ToInt32(inputS);
                        if (string.IsNullOrWhiteSpace(inputC))
                        {
                            for (int i = 0; i < Vehicles.Count; i++)
                            {
                                if (Vehicles[i].SeatCount == Seats) Console.WriteLine($"{i}. {Vehicles[i].ToString()}");
                                found = true;
                            }
                            if (!found) Console.WriteLine("INGA FORDON HITTADES");
                            return true;
                        }
                        else
                        {
                            inputC = inputC.ToLower();
                            for (int i = 0; i < Vehicles.Count; i++)
                            {
                                if (Vehicles[i].SeatCount == Seats && Vehicles[i].Colour == inputC) Console.WriteLine($"{i}. {Vehicles[i].ToString()}");
                                Console.WriteLine("Inga fordon hittades!");
                            }
                            if (!found) Console.WriteLine("INGA FORDON HITTADES");
                            return true;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("ANGE SÄTESANTAL I INTEGERVÄRDE");
                    }
                }
            }
        }
    }

    public static void VehicleSort(Garage Storage)
    {
        if (Storage.GetUsedSpace() > 1)
        {   
            while(true)
            {
                try
                {
                    Console.WriteLine("Vad vill du sortera på: ");
                    Console.WriteLine("1. Färg");
                    Console.WriteLine("2. Antal säten");
                    Console.WriteLine("3. Registreringsnummer");
                    Console.Write("Här: ");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    if (answer < 1) Console.WriteLine("Ge ett giltigt tal");
                    else if (answer > 3) Console.WriteLine("Ge ett giltigt tal");
                else{
                    Storage.Sort(answer);
                    break;
                }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please follow instructions as written");
                }
            }
        }
        else
        {
            Console.WriteLine("För få fordon för sortering");
        }
    }

    public static void ListVehicles(Garage Storage)
    {
        if (Storage.GetUsedSpace() == 0)
        {
            Console.WriteLine("Garaget är tomt!");
        }
        else
        {
            foreach (Vehicle item in Storage.GetStorage())
            {
                Console.WriteLine($"{Storage.GetStorage().IndexOf(item)}. {item.ToString()}");
            }
        }
    }

    public static void ListVehicleTypes(Garage Storage)
    {
        foreach (KeyValuePair<string, int> kvp in Storage.GetCount())
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}