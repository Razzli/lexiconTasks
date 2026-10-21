namespace OvningFem.Vehicles;

class Vehicle
{
    protected string _registry;
    protected string _colour;
    protected int _seatCount;

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
        set
        {
            this._registry = value;
        }
    }

    public string Colour
    {
        get
        {
            return this._colour;
        }
        set
        {
            this._colour = value;
        }

    }

    public int SeatCount
    {
        get
        {
            return this._seatCount;
        }
        set
        {
            this._seatCount = value;
        }
    }
}