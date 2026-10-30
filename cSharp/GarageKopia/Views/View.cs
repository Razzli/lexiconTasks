using GarageKopia.Controllers;
using GarageKopia.Garages;
using GarageKopia.Vehicles;

namespace GarageKopia.Views;

class View
{
    private Garage Storage;
    private readonly string[] StartMenu = [
        "Vänligen skapa ett garage:\n",
        "1. För att skapa ett tomt garage\n",
        "2. För ett populerat garage\n",
        "3. För att skapa ett slumpat garage\n",
        "Ange input: "
    ];
    private readonly string[] Menu = [
        "DU HAR ETT GARAGE\n",
        "DU KAN GÖRA FÖLJANDE:\n",
        "1. LISTA FORDON\n",
        "2. LISTA FORDONSTYPER\n",
        "3. LÄGG TILL ETT FORDON\n",
        "4. TA BORT ETT FORDON\n",
        "5. SORTERA FORDON\n",
        "6. SÖK FORDON EFTER EGENSKAP\n",
        "7. SÖK FORDON EFTER REGISTRERINGSNUMMER\n",
        "8. SKAPA ETT NYTT TOMT GARAGE\n",
        "9. SKAPA ETT NYTT POPULERAT GARAGE\n",
        "10. SKAPA ETT NYTT SLUMPAT GARAGE\n",
        "11. AVSLUTA\n",
        "ANGE INPUT: "
    ];

    public View()
    {
        Console.WriteLine("Hej och välkommen till Garageservice 2.0");
        
        bool Running = true;
        while (Running)
        {
            foreach (string item in StartMenu)
            {
                Console.Write(item);
            }
            int choice = IntegerInputHandler.Read();
            switch (choice)
            {
                case 1:
                    Storage = Controller.EmptyGarageCreator();
                    Running = false;
                    break;
                case 2:
                    Storage = Controller.GarageCreator();
                    Running = false;
                    break;
                case 3:
                    Storage = Controller.RandomGarageCreator();
                    Running = false;
                    break;
                default:
                    Console.WriteLine("ANGE 1 ELLER 2! STARTAR OM");
                    break;
            }
        }
        Running = true;
        while (Running)
        {
            foreach (string item in Menu)
            {
                Console.Write(item);
            }
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Controller.ListVehicles(Storage);
                        break;
                    case 2:
                        Controller.ListVehicleTypes(Storage);
                        break;
                    case 3:
                        Controller.VehicleAdd(Storage);
                        break;
                    case 4:
                        Controller.VehicleRemove(Storage);
                        break;
                    case 5:
                        Controller.VehicleSort(Storage);
                        break;
                    case 6:
                        if (Storage.GetUsedSpace() != 0)Controller.VehicleSearch(Storage);
                        else Console.WriteLine("Garaget är tomt!");
                        break;
                    case 7:
                        try
                        {
                            if (Storage.GetUsedSpace() != 0)Console.WriteLine(Controller.RegistryFind(Storage).ToString());
                            else Console.WriteLine("Garaget är tomt!");
                        }
                        catch (ArgumentException ae)
                        {
                            Console.WriteLine(ae.Message);
                        }
                        break;
                    case 8:
                        Storage = Controller.EmptyGarageCreator();
                        break;
                    case 9:
                        Storage = Controller.GarageCreator();
                        break;
                    case 10:
                        Storage = Controller.RandomGarageCreator();
                        break;
                    case 11:
                        Console.WriteLine("AVSLUTAR");
                        Running = false;
                        break;
                    default:
                        Console.WriteLine("ANGE ETT GILTIGT ALTERNATIV");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("ANGE ETT TAL I INTEGERFORMAT");
            }
        }
    }

    
}