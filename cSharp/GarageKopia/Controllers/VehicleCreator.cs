using GarageKopia.Vehicles;
using System.Text.RegularExpressions;

namespace GarageKopia.Controllers;

class VehicleCreator
{
    public static Vehicle Create(List<Vehicle> Vehicles)
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
                                Registry = RegistryCheck(Vehicles);
                                Colour = ColourPicker();                                
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
                            catch (System.Exception)
                            {
                                Console.WriteLine("FEL FÖRSÖK IGEN");
                            }
                        }
                    case 2:
                        while(true)
                        {
                            try
                            {
                                Console.WriteLine("Du har valt: Båt");   
                                Registry = RegistryCheck(Vehicles);     
                                Colour = ColourPicker();
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
                            catch (System.Exception)
                            {
                                Console.WriteLine("FEL FÖRSÖK IGEN");
                            }
                        }
                    case 3:
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Du har valt: Buss");
                                Registry = RegistryCheck(Vehicles);
                                Colour = ColourPicker();
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
                            catch (System.Exception)
                            {
                                Console.WriteLine("FEL FÖRSÖK IGEN");
                            }
                        }
                    case 4:
                        while(true)
                        {
                            try
                            {
                                Console.WriteLine("Du har valt: Bil");
                                Registry = RegistryCheck(Vehicles);
                                Colour = ColourPicker();
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
                            catch (System.Exception)
                            {
                                Console.WriteLine("FEL FÖRSÖK IGEN");
                            }
                        }
                    case 5:
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Du har valt: Motorcykel");
                                Registry = RegistryCheck(Vehicles);
                                Colour = ColourPicker();
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
                            catch (System.Exception)
                            {
                                Console.WriteLine("FEL FÖRSÖK IGEN");
                            }
                        }
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

    public static string RegistryCheck(List<Vehicle> Vehicles)
    {
        Regex regex = new Regex("[A-Za-z]{3,3}[0-9]{2,2}[A-Za-z0-9]{1,1}");
        bool match = false;
        while (true){
            Console.Write("Ange Registrering: ");
            string Registry = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(Registry))
            {
                if (!regex.IsMatch(Registry))
                {
                    foreach (Vehicle item in Vehicles)
                    {
                        if (item.Registry == Registry) match = true;
                    }
                    if (!match) return Registry;
                    else Console.WriteLine("REGISTRERINGSNUMMRET ÄR EJ UNIKT");
                }
                else
                {
                    Console.WriteLine("VÄNLIGEN ANGE ETT GILTIGT REGISTRERINGSNUMMER");
                }
            }
            else
            {
                Console.WriteLine("VÄNLIGEN GE INPUT");
            }
        }
    }

    public static string ColourPicker()
    {
        string Colour;
        while (true)
        {
            Console.Write("Ange färg: ");
            Colour = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(Colour)) return Colour;
            Console.WriteLine("Vänligen ge en input!");
        }
    }
}