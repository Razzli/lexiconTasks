namespace OvningFem.Vehicles;

class Bus : Vehicle
{
    private bool _roofAccess;
    private int _wheelCount;
    private int _engineCount;

    public Bus(string Colour, int SeatCount, string Registry, string Propulsion, bool RoofAccess, int WheelCount, int EngineCount)
    {
        this.Colour = Colour;
        this.SeatCount = SeatCount;
        this.Registry = Registry;
        this.Propulsion = Propulsion;
        this.RoofAccess = RoofAccess;
        this.WheelCount = WheelCount;
        this.EngineCount = EngineCount;
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

    public int EngineCount
    {
        get
        {
            return this._engineCount;
        }
        init
        {
            this._engineCount = EngineCount;
        }
    }
}