using OvningAtta.Classes;
using OvningAtta.Interfaces;
namespace OvningAtta;

class Program
{
    static void Main(string[] args)
    {
        Program1 Ett = new Program1();
        Program2 Tva = new Program2();
        //Ett.Run();
        //Tva.Go();

        Ett.Start();
        Tva.Start();
        Ett.Start2();

        IAdvancedVoid AdvancedVoid = new ProgramAdvanced();
        AdvancedVoid.Run();
        IAdvancedNumber AdvancedNumber = new ProgramAdvanced();
        AdvancedNumber.Run();

    }
}