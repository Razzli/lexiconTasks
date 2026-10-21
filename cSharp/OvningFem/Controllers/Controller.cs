using OvningFem.Garages;
using OvningFem.Vehicles;

namespace Ovningfem.Controllers;

class Controller
{
    //TODO MAKE LESS THEN 100 LINES
    public static Vehicle VehicleCreator()
    {
        string Colour, Registry;
        int SeatCount;
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
                    case 1:
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Du har valt: Flygplan");
                                Console.Write("Ange färg: ");
                                Colour = Console.ReadLine();
                                if (!string.IsNullOrWhiteSpace(Colour))
                                {
                                    Console.Write("Ange Registrering: ");
                                    Registry = Console.ReadLine();
                                    if (!string.IsNullOrWhiteSpace(Registry))
                                    {
                                        Console.Write("Ange säten: ");
                                        SeatCount = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Ange vingspann: ");
                                        int Wingspan = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Ange motorantal: ");
                                        int Engines = Convert.ToInt32(Console.ReadLine());
                                        Airplane Plane = new Airplane(Colour, SeatCount, Registry, Wingspan, Engines);
                                        Console.WriteLine($"Du har skapat: {Plane.ToString()}");
                                        return Plane;
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                Console.WriteLine("FEL FÖRSÖK IGEN");
                            }
                            
                        }
                    case 2:
                    try
                            {
                                Console.WriteLine("Du har valt: Båt");
                                Console.Write("Ange färg: ");
                                Colour = Console.ReadLine();
                                if (!string.IsNullOrWhiteSpace(Colour))
                                {
                                    Console.Write("Ange Registrering: ");
                                    Registry = Console.ReadLine();
                                    if (!string.IsNullOrWhiteSpace(Registry))
                                    {
                                        Console.Write("Ange säten: ");
                                        SeatCount = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Ange Längd: ");
                                        int Length = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Ange motorantal: ");
                                        int EngineCount = Convert.ToInt32(Console.ReadLine());
                                        Boat Bot = new Boat(Colour, SeatCount, Registry, Length, EngineCount);
                                        Console.WriteLine($"Du har skapat: {Bot.ToString()}");
                                        return Bot;
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                Console.WriteLine("FEL FÖRSÖK IGEN");
                            }
                        break;
                    case 3:
                    try
                            {
                                Console.WriteLine("Du har valt: Buss");
                                Console.Write("Ange färg: ");
                                Colour = Console.ReadLine();
                                if (!string.IsNullOrWhiteSpace(Colour))
                                {
                                    Console.Write("Ange Registrering: ");
                                    Registry = Console.ReadLine();
                                    if (!string.IsNullOrWhiteSpace(Registry))
                                    {
                                        Console.Write("Ange säten: ");
                                        SeatCount = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Ange antal hjul: ");
                                        int WheelCount = Convert.ToInt32(Console.ReadLine());
                                        Bus Buss;
                                        while (true)
                                        {
                                            Console.Write("Tak access y/n: ");
                                            string Answer = Console.ReadLine().ToLower();
                                            switch (Answer)
                                            {
                                                case "y":
                                                    Buss = new Bus(Colour, SeatCount, Registry, true, WheelCount);
                                                    Console.WriteLine($"Du har skapat: {Buss.ToString()}");
                                                    return Buss;
                                                case "n":
                                                    Buss = new Bus(Colour, SeatCount, Registry, true, WheelCount);
                                                    Console.WriteLine($"Du har skapat: {Buss.ToString()}");
                                                    return Buss;
                                                default:
                                                    Console.WriteLine("FEL SVAR");
                                                    break;
                                            }
                                        }
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                Console.WriteLine("FEL FÖRSÖK IGEN");
                            }
                        break;
                    case 4:
                        try
                            {
                                Console.WriteLine("Du har valt: Bil");
                                Console.Write("Ange färg: ");
                                Colour = Console.ReadLine();
                                if (!string.IsNullOrWhiteSpace(Colour))
                                {
                                    Console.Write("Ange Registrering: ");
                                    Registry = Console.ReadLine();
                                    if (!string.IsNullOrWhiteSpace(Registry))
                                    {
                                        Console.Write("Ange säten: ");
                                        SeatCount = Convert.ToInt32(Console.ReadLine());
                                        Car Bil;
                                        while (true)
                                        {
                                            Console.Write("Takfönster y/n: ");
                                            string Answer = Console.ReadLine().ToLower();
                                            switch (Answer)
                                            {
                                                case "y":
                                                    Bil = new Car(Colour, SeatCount, Registry, true);
                                                    Console.WriteLine($"Du har skapat: {Bil.ToString()}");
                                                    return Bil;
                                                case "n":
                                                    Bil = new Car(Colour, SeatCount, Registry, false);
                                                    Console.WriteLine($"Du har skapat: {Bil.ToString()}");
                                                    return Bil;
                                                default:
                                                    Console.WriteLine("FEL SVAR");
                                                    break;
                                            }
                                        }
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                Console.WriteLine("FEL FÖRSÖK IGEN");
                            }
                        break;
                    case 5:
                        try
                            {
                                Console.WriteLine("Du har valt: Motorcykel");
                                Console.Write("Ange färg: ");
                                Colour = Console.ReadLine();
                                if (!string.IsNullOrWhiteSpace(Colour))
                                {
                                    Console.Write("Ange Registrering: ");
                                    Registry = Console.ReadLine();
                                    if (!string.IsNullOrWhiteSpace(Registry))
                                    {
                                        Console.Write("Ange säten: ");
                                        SeatCount = Convert.ToInt32(Console.ReadLine());
                                        Motorcycle Motorcykel;
                                        while (true)
                                        {
                                            Console.Write("Förvaring y/n: ");
                                            string Answer = Console.ReadLine().ToLower();
                                            switch (Answer)
                                            {
                                                case "y":
                                                    Motorcykel = new Motorcycle(Colour, SeatCount, Registry, true);
                                                    Console.WriteLine($"Du har skapat: {Motorcykel.ToString()}");
                                                    return Motorcykel;
                                                case "n":
                                                    Motorcykel = new Motorcycle(Colour, SeatCount, Registry, false);
                                                    Console.WriteLine($"Du har skapat: {Motorcykel.ToString()}");
                                                    return Motorcykel;
                                                default:
                                                    Console.WriteLine("FEL SVAR");
                                                    break;
                                            }
                                        }
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                Console.WriteLine("FEL FÖRSÖK IGEN");
                            }
                        break;
                    default:
                        Console.WriteLine("Ge ett giltigt tal");
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
        Console.WriteLine("EJ IMPLEMENTERAD");
    }

    public static void VehicleSort(Garage Storage)
    {
        /**
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
        **/
        Console.WriteLine("EJ IMPLEMENTERAD");
    }

    public static void ListVehicles(Garage Storage)
    {
        if (Storage.GetUsedSpace() == 0)
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