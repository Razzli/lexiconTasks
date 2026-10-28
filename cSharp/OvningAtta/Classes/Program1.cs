using OvningAtta.Interfaces;
namespace OvningAtta.Classes;

class Program1 : IProgram, IProgram2
{
    /**
    public void Run()
    {
        Console.WriteLine("Nu kör vi program 1");
    }
    **/

    public void Start()
    {
        Console.WriteLine("Nu kör vi program 1");
    }
    public void Start2()
    {
        Console.WriteLine("Nu kör vi program 1 igen");
    }
}
