namespace OvningNio.Model.Vehicle;

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

    public bool CompareColour(IVehicle Target)
    {
        return string.Compare(this.Colour, Target.Colour) >= 0;
    }

    public bool CompareRegistry(IVehicle Target)
    {
        return string.Compare(this.Registry, Target.Registry) >= 0;
    }

    public bool CompareSeatCount(IVehicle Target)
    {
        return this.SeatCount >= Target.SeatCount;
    }

    public abstract override string ToString();
    public abstract string Localization{get;}
}