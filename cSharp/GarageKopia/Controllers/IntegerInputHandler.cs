namespace GarageKopia.Controllers;

class IntegerInputHandler
{
    public static int Read()
    {
        while (true)
        {
            try
            {
                string? arg = Console.ReadLine();
                return Convert.ToInt32(arg);
            }
            catch (System.FormatException)
            {
                Console.Write("VÄNLIGEN GE ETT INTEGERVÄRDE\n Försök igen: ");
            }
        }
    }
}