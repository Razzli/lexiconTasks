namespace OvningNio.Controller.Input;

class InputHandler : IStringInputHandler, IIntInputHandler
{
    string IStringInputHandler.Read()
    {
        string? Input;
        while (true)
        {
            Input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(Input))
            {
                return Input;
            }
            else
            {
                Console.Write("FEL! GE INPUT!\nFörsök igen: ");
            }
        }
    }

    int IIntInputHandler.Read()
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