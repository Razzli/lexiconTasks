namespace GarageKopia.Controllers;

class StringInputHandler
{
    public static string Read()
    {
        string? YNBool;
        while (true)
        {
            YNBool = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(YNBool))
            {
                return YNBool;
            }
            else
            {
                Console.Write("FEL! GE INPUT!\nFörsök igen: ");
            }
        }
    }
}