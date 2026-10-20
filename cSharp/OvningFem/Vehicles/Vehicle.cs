namespace OvningFem.Vehicles;

class Vehicle
{
    private string _registry;
    private string _colour;
    private int _seatCount;
    private string _propulsion;

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

    public string Propulsion
    {
        get
        {
            return this._propulsion;
        }
        init
        {
            this._propulsion = Propulsion;
        }
    }
}