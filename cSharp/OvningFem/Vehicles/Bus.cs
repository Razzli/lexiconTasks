namespace OvningFem.Vehicles;

class Bus : Vehicle
{
    private bool _roofAccess;
    private int _wheelCount;

    public Bus(string Colour, int SeatCount, string Registry, bool RoofAccess, int WheelCount)
    {
        this.Colour = Colour;
        this.SeatCount = SeatCount;
        this.Registry = Registry;
        this.RoofAccess = RoofAccess;
        this.WheelCount = WheelCount;
    }

//TODO implement hasRoofAccess
    public bool RoofAccess
    {
        get
        {
            return this._roofAccess;
        }
        set
        {
            this._roofAccess = value;
        }
    }

    public int WheelCount
    {
        get
        {
            return this._wheelCount;
        }
        set
        {
            this._wheelCount = value;
        }
    }
    public override string ToString()
    {
        if (this._roofAccess) return $"En buss med registreringsnummret {this._registry}, färgen {this._colour}, {this._seatCount} säten, {this._wheelCount} hjul med takaccess";
        return $"En buss med registreringsnummret {this._registry}, färgen {this._colour}, {this._seatCount} säten, {this._wheelCount} hjul utan takaccess";
    }
}