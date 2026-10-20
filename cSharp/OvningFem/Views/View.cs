using Ovningfem.Controllers;
using OvningFem.Garages;
using OvningFem.Vehicles;

namespace OvningFem.Views;

class View
{
    private Garage Storage;
    private Controller Control = new Controller();
    private string[] menu = [
        "DU HAR ETT GARAGE\n",
        "DU KAN GÖRA FÖLJANDE:\n",
        "1. LISTA FORDON\n",
        "2. LISTA FORDONSTYPER\n",
        "3. LÄGG TILL ETT FORDON\n",
        "4. TA BORT ETT FORDON\n",
        "5. SORTERA FORDON\n",
        "6. SÖK FORDON EFTER EGENSKAP\n",
        "7. SKAPA ETT NYTT TOMT GARAGE\n",
        "8. SKAPA ETT NYTT POPULERAT GARAGE\n",
        "9. AVSLUTA\n",
        "ANGE INPUT: "
    ];

    public View()
    {
        Console.WriteLine("Hej och välkommen till Garageservice 1.0");
        
        bool Running = true;
        while (Running)
        {
            Console.WriteLine("Vänligen skapa ett garage:");
            Console.WriteLine("1. För att skapa ett tomt garage");
            Console.WriteLine("2. För ett populerat garage");
            Console.Write("Ange input: ");
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
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
                    default:
                        Console.WriteLine("ANGE 1 ELLER 2! STARTAR OM");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("FEL! ANGE TAL I INTEGERFORMAT");
            }
        }
        Running = true;
        while (Running)
        {
            foreach (string item in menu)
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
                        Controller.VehicleSearch(Storage);
                        break;
                    case 7:
                        Storage = Controller.EmptyGarageCreator();
                        break;
                    case 8:
                        Storage = Controller.GarageCreator();
                        break;
                    case 9:
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