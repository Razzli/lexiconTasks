using GarageKopia.Vehicles;
using System.ComponentModel.Design;
using System.Text.RegularExpressions;

namespace GarageKopia.Controllers;

class VehicleCreator
{
    private readonly static string[] Menu = [
        "Ange fordonstyp: \n",
        "1. Flygplan\n",
        "2. Båt\n",
        "3. Buss\n",
        "4. Bil\n",
        "5. MotorCykel\n",
        "Här: "
    ];
    public static Vehicle Create(List<Vehicle> Vehicles)
    {
        
        string Colour, Registry;
        int SeatCount;
        while(true){
            foreach (string item in Menu)
            {
                Console.Write(Menu);
            }
            int answer = IntegerInputHandler.Read();
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
                        int Wingspan = IntegerInputHandler.Read();
                        Console.Write("Ange motorantal: ");
                        int Engines = IntegerInputHandler.Read();
                        Airplane Plane = new Airplane(Colour, SeatCount, Registry, Wingspan, Engines);
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
                        int Length = IntegerInputHandler.Read();
                        Console.Write("Ange motorantal: ");
                        int EngineCount = IntegerInputHandler.Read();
                        Boat Bot = new Boat(Colour, SeatCount, Registry, Length, EngineCount);
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
                        int WheelCount = IntegerInputHandler.Read();
                        Bus Buss;
                        while (true)
                        {
                            Console.Write("Tak access y/n: ");
                            string Answer = StringInputHandler.Read().ToLower();
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
                            string Answer = StringInputHandler.Read().ToLower();
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
                case 5:
                    while (true)
                    {
                        Console.WriteLine("Du har valt: Motorcykel");
                        Registry = RegistryCheck(Vehicles);
                        Colour = ColourPicker();
                        SeatCount = SeatPicker();
                        Motorcycle Motorcykel;
                        while (true)
                        {
                            Console.Write("Förvaring y/n: ");
                            string Answer = StringInputHandler.Read().ToLower();
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
                default:
                    Console.WriteLine("Ge ett giltigt tal");
                    break;
            }
        }
    }

    public static string RegistryCheck(List<Vehicle> Vehicles)
    {
        Regex regex = new Regex("[A-Za-z]{3,3}[0-9]{2,2}[A-Za-z0-9]{1,1}");
        bool match = false;
        string? Registry;
        while (true){
            Console.Write("Ange Registrering: ");
            Registry = StringInputHandler.Read();
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
    }

    public static string ColourPicker()
    {
        Console.Write("Ange färg: ");
        return StringInputHandler.Read();
    }

    public static int SeatPicker()
    {
        Console.Write("Ange säten: ");
        return IntegerInputHandler.Read();
    }
}