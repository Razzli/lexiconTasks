namespace OvningNio.Model.Vehicles;

abstract class Vehicle : IVehicle
{
    private string _registry;
    private string _colour;
    private int _seatCount;

    public string Registry 
    {
        get => _registry;
        set => _registry = value;
    }
    public string Colour
    {
        get => _colour;
        set => _colour = value;
    }
    public int SeatCount
    {
        get => _seatCount;
        set => _seatCount = value;
    }
    //https://learn.microsoft.com/en-us/dotnet/api/system.comparison-1?view=net-10.0
    static public int CompareColour(IVehicle Vehicle1, IVehicle Vehicle2)
    {
        return string.Compare(Vehicle1.Colour, Vehicle2.Colour);
    }

    static public int CompareRegistry(IVehicle Vehicle1, IVehicle Vehicle2)
    {
        return string.Compare(Vehicle1.Registry, Vehicle2.Registry);
    }

    static public int CompareSeatCount(IVehicle Vehicle1, IVehicle Vehicle2)
    {
        return Vehicle1.SeatCount.CompareTo(Vehicle2.SeatCount);
    }

    public abstract override string ToString();

    public abstract string Localization{get;}
}