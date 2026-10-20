namespace OvningFem.Vehicles;

class Vehicle
{
    private string _registry;
    private string _colour;
    private int _seatCount;

    public bool CompareRegistry(Vehicle Target)
    {
        if (_registry.CompareTo(Target.Registry) < 0) { return true; }
        return false;
    }

    public bool CompareColour(Vehicle Target)
    {
        if (_colour.CompareTo(Target.Colour) < 0) { return true; }
        return false;
    }

    public bool CompareSeat(Vehicle Target)
    {
        return _seatCount <= Target.SeatCount;
    }

    public string Registry
    {
        get
        {
            return this._registry;
        }
        init
        {
            this._registry = Registry;
        }
    }

    public string Colour
    {
        get
        {
            return this._colour;
        }
        init
        {
            this._colour = Colour;
        }

    }

    public int SeatCount
    {
        get
        {
            return this._seatCount;
        }
        init
        {
            this._seatCount = SeatCount;
        }
    }
}