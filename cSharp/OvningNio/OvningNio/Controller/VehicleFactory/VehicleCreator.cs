using OvningNio.Model.Garage;
using OvningNio.Model.Vehicles;
using OvningNio.Model.Vehicles.Boat;
using OvningNio.Model.Vehicles.Bus;
using OvningNio.Model.Vehicles.Car;
using OvningNio.Model.Vehicles.MotorCycle;
using OvningNio.Model.Vehicles.Plane;
using OvningNio.Controller.Input;
using System.Text.RegularExpressions;

namespace OvningNio.Controller.VehicleFactory;
//Starting to see the limitation of my chosen architecture
public class VehicleCreator : IVehicleCreator, IRandomVechicleCreator
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
    private readonly IIntInputHandler IntReader = new InputHandler();
    private readonly IStringInputHandler StringReader = new InputHandler();
    private readonly static string[] Menu = [
        "Ange fordonstyp: \n",
        "1. Flygplan\n",
        "2. Båt\n",
        "3. Buss\n",
        "4. Bil\n",
        "5. MotorCykel\n",
        "Här: "
    ];
    Vehicle IVehicleCreator.Create(List<Vehicle> Storage)
    {   
        string Colour, Registry;
        int SeatCount;
        List<Vehicle> Vehicles = Storage;
        while(true){
            foreach (string item in Menu)
            {
                Console.Write(item);
            }
            int answer = IntReader.Read();
            switch (answer)
            {
                case 1:
                    while (true)
                    {
                        Console.WriteLine("Du har valt: Flygplan");
                        Registry = RegistryCheck(Vehicles);
                        Colour = ColourPicker();                                
                        SeatCount = SeatPicker();
                        Console.Write("Ange vingspann: ");
                        int Wingspan = IntReader.Read();
                        Console.Write("Ange motorantal: ");
                        int Engines = IntReader.Read();
                        Plane Plane = new Plane(Registry, Colour, SeatCount, Wingspan, Engines);
                        Console.WriteLine($"Du har skapat: {Plane.ToString()}");
                        return Plane;
                    }
                case 2:
                    while(true)
                    {
                        Console.WriteLine("Du har valt: Båt");   
                        Registry = RegistryCheck(Vehicles);     
                        Colour = ColourPicker();
                        SeatCount = SeatPicker();
                        Console.Write("Ange Längd: ");
                        int Length = IntReader.Read();
                        Console.Write("Ange motorantal: ");
                        int EngineCount = IntReader.Read();
                        Boat Bot = new Boat(Registry, Colour, SeatCount, Length, EngineCount);
                        Console.WriteLine($"Du har skapat: {Bot.ToString()}");
                        return Bot;
                    }
                case 3:
                    while (true)
                    {
                        Console.WriteLine("Du har valt: Buss");
                        Registry = RegistryCheck(Vehicles);
                        Colour = ColourPicker();
                        SeatCount = SeatPicker();
                        Console.Write("Ange antal hjul: ");
                        int WheelCount = IntReader.Read();
                        Bus Buss;
                        while (true)
                        {
                            Console.Write("Tak access y/n: ");
                            string Answer = StringReader.Read().ToLower();
                            switch (Answer)
                            {
                                case "y":
                                    Buss = new Bus(Registry, Colour, SeatCount, true, WheelCount);
                                    Console.WriteLine($"Du har skapat: {Buss.ToString()}");
                                    return Buss;
                                case "n":
                                    Buss = new Bus(Registry, Colour, SeatCount, true, WheelCount);
                                    Console.WriteLine($"Du har skapat: {Buss.ToString()}");
                                    return Buss;
                                default:
                                    Console.WriteLine("FEL SVAR");
                                    break;
                            }
                        }                
                    }
                case 4:
                    while(true)
                    {
                        Console.WriteLine("Du har valt: Bil");
                        Registry = RegistryCheck(Vehicles);
                        Colour = ColourPicker();
                        SeatCount = SeatPicker();
                        Car Bil;
                        while (true)
                        {
                            Console.Write("Takfönster y/n: ");
                            string Answer = StringReader.Read().ToLower();
                            switch (Answer)
                            {
                                case "y":
                                    Bil = new Car(Registry, Colour, SeatCount, true);
                                    Console.WriteLine($"Du har skapat: {Bil.ToString()}");
                                    return Bil;
                                case "n":
                                    Bil = new Car(Registry, Colour, SeatCount, false);
                                    Console.WriteLine($"Du har skapat: {Bil.ToString()}");
                                    return Bil;
                                default:
                                    Console.WriteLine("FEL SVAR");
                                    break;
                            }
                        }
                    }
                case 5:
                    while (true)
                    {
                        Console.WriteLine("Du har valt: Motorcykel");
                        Registry = RegistryCheck(Vehicles);
                        Colour = ColourPicker();
                        SeatCount = SeatPicker();
                        MotorCycle Motorcykel;
                        while (true)
                        {
                            Console.Write("Förvaring y/n: ");
                            string Answer = StringReader.Read().ToLower();
                            switch (Answer)
                            {
                                case "y":
                                    Motorcykel = new MotorCycle(Registry, Colour, SeatCount, true);
                                    Console.WriteLine($"Du har skapat: {Motorcykel.ToString()}");
                                    return Motorcykel;
                                case "n":
                                    Motorcykel = new MotorCycle(Registry, Colour, SeatCount, false);
                                    Console.WriteLine($"Du har skapat: {Motorcykel.ToString()}");
                                    return Motorcykel;
                                default:
                                    Console.WriteLine("FEL SVAR");
                                    break;
                            }
                        }                              
                    }
                default:
                    Console.WriteLine("Ge ett giltigt tal");
                    break;
            }
        }
    }

    Vehicle IRandomVechicleCreator.Create(List<Vehicle> Storage)
    {
        int Choice = Rand.Next(5);
        string Colour = _colours[Rand.Next(_colours.Length)];
        string Registry = RegistryCreator(Storage);
        Vehicle vehicle;
        switch (Choice)
        {
            case 0:
                vehicle = new Plane(Registry, Colour, Rand.Next(10, 30), Rand.Next(30, 50), Rand.Next(2, 5));
                break;
            case 1:
                vehicle = new Boat(Registry, Colour, Rand.Next(2, 10), Rand.Next(5, 20), Rand.Next(1, 5));
                break;
            case 2:
                //Thank you https://stackoverflow.com/questions/19191058/fastest-way-to-generate-a-random-boolean
                vehicle = new Bus(Registry, Colour, Rand.Next(10, 20), Rand.NextDouble() >= 0.5, 6);
                break;
            case 3:
                vehicle = new Car(Registry, Colour, Rand.Next(4,6), Rand.NextDouble() >= 0.5);
                break;
            case 4:
                vehicle = new MotorCycle(Registry, Colour, Rand.Next(1, 3), Rand.NextDouble() >= 0.5);
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

    private string RegistryCheck(List<Vehicle> Vehicles)
    {
        Regex regex = new Regex("[A-Za-z]{3,3}[0-9]{2,2}[A-Za-z0-9]{1,1}");
        bool match = false;
        string? Registry;
        while (true){
            Console.Write("Ange Registrering: ");
            Registry = StringReader.Read();
            if (regex.IsMatch(Registry) && Registry.Length == 6)
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
    }

    private string ColourPicker()
    {
        Console.Write("Ange färg: ");
        return StringReader.Read();
    }

    private int SeatPicker()
    {
        Console.Write("Ange säten: ");
        return IntReader.Read();
    }
}