using OvningAtta.Interfaces;

namespace OvningAtta.Classes;

class ProgramAdvanced : IAdvancedNumber, IAdvancedVoid
{
    void IAdvancedVoid.Run()
    {
        Console.WriteLine("Detta är void");
    }
    int IAdvancedNumber.Run()
    {
        Console.WriteLine("Detta är int");
        return 7;
    }
}