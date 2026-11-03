using Microsoft.Win32;
using OvningNio.Controller.Input;
using OvningNio.Controller.VehicleFactory;
using OvningNio.Model.Garage;
using OvningNio.Model.Vehicle;

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
        throw new NotImplementedException();
    }

    public Garage<Vehicle> RGarageCreator()
    {
        throw new NotImplementedException();
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

    public void VehicleAdd(Garage<Vehicle> Garage)
    {
        throw new NotImplementedException();
    }

    public void VehicleRemove(Garage<Vehicle> Garage)
    {
        ListVehicles(Garage);
        Console.Write("Ange index för fordon att ta bort: ");
        int Target = IntReader.Read();
        bool Success = Garage.Remove(Garage.Storage[Target]);
        if (Success) Console.WriteLine($"Fordon på index {Target} borttaget!");
        else Console.WriteLine("Fordon ej borttaget, kolla ifall du har givet rätt index!");
    }

    public void VehicleSearch(Garage<Vehicle> Garage)
    {
        throw new NotImplementedException();
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

    public void VehicleSort(Garage<Vehicle> Garage)
    {
        throw new NotImplementedException();
    }
}