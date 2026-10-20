
using System.Runtime.InteropServices.Marshalling;
using OvningFem.Garages;
using OvningFem.Vehicles;

namespace Ovningfem.Controllers;

class Controller
{
    public static Vehicle VehicleCreator()
    {
        while(true){
            try
            {
                Console.WriteLine("Ange fordonstyp: ");
                Console.WriteLine("1. Flygplan");
                Console.WriteLine("2. Båt");
                Console.WriteLine("3. Buss");
                Console.WriteLine("4. Bil");
                Console.WriteLine("5. MotorCykel");
                Console.Write("Här: ");
                int answer = Convert.ToInt32(Console.ReadLine());
                switch (answer)
                {
                    
                    default:
                        Console.WriteLine("Ge ett giltigt integertal");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please follow instructions as written");
            }
        }
    }
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
                        Vehicle[] Vehicles = new Vehicle[Amount];
                        for (int i = 0; i < Amount; i++)
                        {
                            Vehicles[i] = VehicleCreator();
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

    public static void VehicleAdd(Garage Storage)
    {
        if (Storage.GetFreeSpace() == 0) Console.WriteLine("GARAGE FULLT!");
        else
        {
            Storage.AddVehicle(VehicleCreator());
            Console.WriteLine("FORDON TILLAGT");
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

    public static void VehicleSearch(Garage Storage)
    {
        throw new NotImplementedException();
    }

    public static void VehicleSort(Garage Storage)
    {
        if (Storage.GetUsedSpace() > 1)
        {
            while(true){
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
                    else Storage.Sort(answer);
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
        if (Storage.GetFreeSpace() == 0)
        {
            Console.WriteLine("Garaget är tomt!");
        }
        else
        {
            Vehicle[] Vehicles = Storage.GetStorage();
            for (int i = 0; i < Vehicles.Length; i++)
            {
                Console.WriteLine($"{(i+1)}. {Vehicles[i].ToString()}");
            }
        }
    }

    public static void ListVehicleTypes(Garage Storage)
    {
        int[] TypeCount = Storage.GetCount();
        Console.WriteLine("Garaget innehåller: ");
        Console.WriteLine($"{TypeCount[0]} Flygplan");
        Console.WriteLine($"{TypeCount[1]} Båtar");
        Console.WriteLine($"{TypeCount[2]} Bussar");
        Console.WriteLine($"{TypeCount[3]} Bilar");
        Console.WriteLine($"{TypeCount[4]} Motorcyklar");
    }
}