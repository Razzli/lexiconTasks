using System.Dynamic;

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

    public IVehicle CompareColour(IVehicle Vehicle)
    {
        throw new NotImplementedException();
    }

    public IVehicle CompareRegistry(IVehicle Vehicle)
    {
        throw new NotImplementedException();
    }

    public IVehicle CompareSeatCount(IVehicle Vehicle)
    {
        throw new NotImplementedException();
    }

    public abstract override string ToString();
    public abstract string Localization{get;}
}