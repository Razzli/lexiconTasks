namespace OvningNio.View.Menu;

class Menus : IMainMenu, IStartMenu
{
    private static readonly string[] StartMenu = [
        "Vänligen skapa ett garage:\n",
        "1. För att skapa ett tomt garage\n",
        "2. För ett populerat garage\n",
        "3. För att skapa ett slumpat garage\n",
        "Ange input: "
    ];
    private static readonly string[] MainMenu = [
        "DU HAR ETT GARAGE\n",
        "DU KAN GÖRA FÖLJANDE:\n",
        "1. LISTA FORDON\n",
        "2. LISTA FORDONSTYPER\n",
        "3. LÄGG TILL ETT FORDON\n",
        "4. TA BORT ETT FORDON\n",
        "5. SÖK FORDON EFTER EGENSKAP\n",
        "6. SÖK FORDON EFTER REGISTRERINGSNUMMER\n",
        "7. SKAPA ETT NYTT TOMT GARAGE\n",
        "8. SKAPA ETT NYTT POPULERAT GARAGE\n",
        "9. SKAPA ETT NYTT SLUMPAT GARAGE\n",
        "10. AVSLUTA\n",
        "ANGE INPUT: "
    ];

    void IStartMenu.Show()
    {
        foreach (var item in StartMenu)
        {
            Console.Write(item);
        }
    }

    void IMainMenu.Show()
    {
        foreach (var item in MainMenu)
        {
            Console.Write(item);
        }
    }
}