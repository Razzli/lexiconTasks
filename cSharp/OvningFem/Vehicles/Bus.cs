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
        init
        {
            this._roofAccess = RoofAccess;
        }
    }

    public int WheelCount
    {
        get
        {
            return this._wheelCount;
        }
        init
        {
            this._wheelCount = WheelCount;
        }
    }
    public override string ToString()
    {
        if (this.RoofAccess) return $"En buss med registreringsnummret {this.Registry}, färgen {this.Colour}, {this.SeatCount} säten, {this.WheelCount} hjul med takaccess";
        return $"En buss med registreringsnummret {this.Registry}, färgen {this.Colour}, {this.SeatCount} säten, {this.WheelCount} hjul utan takaccess";
    }
}