namespace OvningFem.Vehicles;

class Airplane : Vehicle
{
    private int _wingspan;
    private int _engineCount;
    private int _wheelCount;

    public Airplane(string Colour, int SeatCount, string Registry, string Propulsion, int Wingspan, int EngineCount, int WheelCount)
    {
        this.Colour = Colour;
        this.SeatCount = SeatCount;
        this.Registry = Registry;
        this.Propulsion = Propulsion;
        this.Wingspan = Wingspan;
        this.EngineCount = EngineCount;
        this.WheelCount = WheelCount;
    }

    public int Wingspan
    {
        get
        {
            return this._wingspan;
        }
        init
        {
            this._wingspan = Wingspan;
        }
    }
    public int EngineCount
    {
        get
        {
            return _engineCount;
        }
        init
        {
            this._engineCount = EngineCount;
        }
    }

    public int WheelCount
    {
        get
        {
            return _wheelCount;
        }
        init
        {
            this._wheelCount = WheelCount;
        }
    }
}