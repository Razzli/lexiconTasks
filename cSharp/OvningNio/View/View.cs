using OvningNio.Controller;
using OvningNio.Controller.Input;
using OvningNio.Model.Garage;
using OvningNio.Model.Vehicle;
using OvningNio.View.Menu;

namespace OvningNio.View;

class View
{
    private bool Running;
    private GarageHandler Handler;
    private Garage<Vehicle> Garage;
    readonly IStartMenu StartMenu = new Menus();
    readonly IMainMenu MainMenu = new Menus();
    readonly IStringInputHandler StringReader = new InputHandler();
    readonly IIntInputHandler IntReader = new InputHandler();
    
    public void Run()
    {
        Running = true;
        while (Running)
        {
            StartMenu.Show();
            int choice = IntReader.Read();
            switch (choice)
            {
                case 1:
                    Garage = Handler.EGarageCreator();
                    Running = false;
                    break;
                case 2:
                    Garage = Handler.GarageCreator();
                    Running = false;
                    break;
                case 3:
                    Garage = Handler.RGarageCreator();
                    Running = false;
                    break;
                default:
                    Console.WriteLine("ANGE GILTIGT SVAR! STARTAR OM");
                    break;
            }
        }
        Running = true;
        while (Running)
        {
            MainMenu.Show();
            int choice = IntReader.Read();
            switch (choice)
            {
                case 1:
                    Handler.ListVehicles(Garage);
                    break;
                case 2:
                    Handler.ListVehicleTypes(Garage);
                    break;
                case 3:
                    Handler.VehicleAdd(Garage);
                    break;
                case 4:
                    Handler.VehicleRemove(Garage);
                    break;
                case 5:
                    Handler.VehicleSort(Garage);
                    break;
                case 6:
                    if (Garage.UsedSpace != 0) Handler.VehicleSearch(Garage);
                    else Console.WriteLine("Garaget är tomt!");
                    break;
                case 7:
                    try
                    {
                        if (Garage.UsedSpace != 0) Handler.RegistryFind(Garage);
                        else Console.WriteLine("Garaget är tomt!");
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }
                    break;
                case 8:
                    Garage = Handler.EGarageCreator();
                    break;
                case 9:
                    Garage = Handler.GarageCreator();
                    break;
                case 10:
                    Garage = Handler.RGarageCreator();
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
    }
}