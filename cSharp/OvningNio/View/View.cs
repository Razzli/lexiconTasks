using OvningNio.Controller;
using OvningNio.Model.Garage;
using OvningNio.Model.Vehicle;

namespace OvningNio.View;

class View : IStartMenu, IMainMenu
{
    private IStartMenu _startMenu = new View();
    private IMainMenu _mainMenu = new View();
    private GarageHandler Handler;
    private Garage<Vehicle> Storage;
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
    public void Run()
    {
        Menu();
    }

    void IStartMenu.Menu()
    {
        foreach (var item in StartMenu)
        {
            Console.Write(item);
        }
    }

    void IMainMenu.Menu()
    {
        throw new NotImplementedException();
    }

    
}