using OvningNio.Controller.Input;
using OvningNio.Controller.VehicleFactory;
using OvningNio.Model.Garage;
using OvningNio.Model.Vehicles;

namespace OvningNio.Controller;

class GarageHandler : IGarageHandler
{
    readonly IStringInputHandler StringReader = new InputHandler();
    readonly IIntInputHandler IntReader = new InputHandler();
    readonly IRandomVechicleCreator RandomVehicle = new VehicleCreator();
    readonly IVehicleCreator VehicleBuilder = new VehicleCreator();
    public Garage<Vehicle> EGarageCreator()
    {
        while (true)
        {
            Console.Write("Ange önskad storlek på garage: ");
            int Size = IntReader.Read();
            if (Size > 0) return new Garage<Vehicle>([], Size);
            Console.WriteLine("Storlek på Garaget måste vara större än 0");
        }
    }

    public Garage<Vehicle> GarageCreator()
    {
        while (true){
            Console.Write("Ange önskad storlek på garaget: ");
            int Size = IntReader.Read();
            if (Size < 1) Console.WriteLine("STORLEK MÅSTE VARA STÖRRE ÄN 0");
            else
            {
                Console.Write("Ange antal fordon du vill skapa: ");
                int Amount = IntReader.Read();
                if (Amount > Size) Console.WriteLine("DU KAN INTE SKAPA FLER FORDON ÄN PLATSER");
                else if (Amount <= 0) Console.WriteLine("SKAPA ÅTMINSTONE 1 FORDON");
                else
                {
                    List<Vehicle> Vehicles = new List<Vehicle>();
                    for (int i = 0; i < Amount; i++)
                    {
                        Vehicles.Add(VehicleBuilder.Create(Vehicles));
                    }
                    return new Garage<Vehicle>(Vehicles, Size);
                }
            }
        }
    }

    public Garage<Vehicle> RGarageCreator()
    {
        while (true)
        {
            Console.Write("Ange önskad storlek på garaget: ");
            int Size = IntReader.Read();
            if (Size > 0)
            {
                Console.Write("Ange önskat antal fordon: ");
                int Amount = IntReader.Read();
                if (Amount >= 0 && Size >= Amount)
                {
                    List<Vehicle> Vehicles = [];
                    for (int i = 0; i < Amount; i++)
                    {
                        Vehicles.Add(RandomVehicle.Create(Vehicles));
                    }
                    return new Garage<Vehicle>(Vehicles, Size);
                }
                else
                {
                    Console.WriteLine("ANTAL FORDON MÅSTE VARA FLER ÄN -1 OCH INTE FLER ÄN GARAGETS STORLEK");
                }
            }
            else
            {
                Console.WriteLine("GARAGET MÅSTE VARA STÖRRE ÄN 1");
            }
        }
    }

    public void ListVehicles(Garage<Vehicle> Garage)
    {
        foreach (var item in Garage)
        {
            Console.WriteLine(item.ToString());
        }
    }

    public void ListVehicleTypes(Garage<Vehicle> Garage)
    {
        var VehicleTypes = Garage.GroupBy(Vehicle => Vehicle.Localization, (Types, Amount) => new {key = Types, Count = Amount.Count()});
        foreach (var item in VehicleTypes)
        {
            Console.WriteLine($"{item.key}: {item.Count}");
        }
    }

    //Hidden gateway to 200+ lines of code i've lost understanding of
    public void VehicleAdd(Garage<Vehicle> Garage)
    {
        if (Garage.Size < Garage.Storage.Count)Garage.Add(VehicleBuilder.Create(Garage.Storage));
        else Console.WriteLine("Garaget är fullt!");
        
    }

    public void VehicleRemove(Garage<Vehicle> Garage)
    {
        ListVehicles(Garage);
        Console.Write("Ange index för fordon att ta bort: ");
        int Target = IntReader.Read();
        if (Target >= 0 && Target < Garage.Storage.Count)
        {
            bool Success = Garage.Remove(Garage.Storage[Target]);
            if (Success) Console.WriteLine($"Fordon på index {Target} borttaget!");
            else Console.WriteLine("Fordon ej borttaget, kolla ifall du har givet rätt index!");
        }
        else
        {
            Console.WriteLine($"Fordon på plats {Target} existerar inte!");
        }
    }

    public void VehicleSearch(Garage<Vehicle> Garage)
    {
        bool Found = false;
        List<Vehicle> Targets = [];
        while (!Found)
        {
            Console.WriteLine("SÖKFUNKTION (LÄMNA BLANKT FÖR ATT INTE SÖKA PÅ EGENSKAP)");
            Console.Write("Ange färg: ");
            string? inputC = Console.ReadLine();
            Console.Write("Ange sätesantal: ");
            string? inputS = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputC) && string.IsNullOrWhiteSpace(inputS)) Console.WriteLine("ANGE ÅTMINSTONE EN EGENSKAP");
            else
            {
                if (string.IsNullOrWhiteSpace(inputS))
                {
                    inputC = inputC.ToLower();
                    Targets = [.. Garage.Storage.Where(Vehicle => Vehicle.Colour == inputC)];
                    Found = true;
                }
                else
                {
                    try
                    {
                        int Seats = Convert.ToInt32(inputS);
                        if (string.IsNullOrWhiteSpace(inputC))
                        {
                            Targets = [.. Garage.Storage.Where(Vehicle => Vehicle.SeatCount == Seats)];
                            Found = true;
                        }
                        else
                        {
                            inputC = inputC.ToLower();
                            Targets = [.. Garage.Storage.Where(Vehicle => Vehicle.Colour == inputC && Vehicle.SeatCount == Seats)];
                            Found = true;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("ANGE SÄTESANTAL I INTEGERVÄRDE");
                    }
                }
            }
        }
        if (Targets.Count > 0)
        {
            foreach (Vehicle item in Targets)
            {
                Console.WriteLine(item.ToString());
            }
        }
        else Console.WriteLine("INGA FORDON HITTADES!");
    }

    public void RegistryFind(Garage<Vehicle> Garage)
    {
        Console.Write("Ange registreringsnummer på önskat fordon: ");
        string Input = StringReader.Read();
        Vehicle Target = (Vehicle)Garage.Where(Vehicle => Vehicle.Registry == Input);
        if (Target is null) Console.WriteLine($"Fordon med registreringsnummret {Input} hittades inte");
        else
        {
            Console.WriteLine($"Fordon hittat på index {Garage.Storage.IndexOf(Target)}");
            Console.WriteLine(Target.ToString());
        }
    }
}