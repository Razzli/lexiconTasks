namespace OvningNio.Model.Vehicles;

public abstract class Vehicle : IVehicle
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

    public abstract override string ToString();

    public abstract string Localization{get;}
}