namespace OvningSex.Vehicles;

class Airplane : Vehicle
{
    private int _wingspan;
    private int _engineCount;
    //Used as a identifier for the typecount function in Controller
    private readonly string _localization = "flygplan";

    public Airplane(string Colour, int SeatCount, string Registry, int Wingspan, int EngineCount)
    {
        this.Colour = Colour;
        this.SeatCount = SeatCount;
        this.Registry = Registry;
        this.Wingspan = Wingspan;
        this.EngineCount = EngineCount;
    }

    public int Wingspan
    {
        get
        {
            return this._wingspan;
        }
        set
        {
            this._wingspan = value;
        }
    }
    public int EngineCount
    {
        get
        {
            return _engineCount;
        }
        set
        {
            this._engineCount = value;
        }
    }

    public override string Localization
    {
        get
        {
            return this._localization;
        }
    }

    public override string ToString()
    {
        return $"Ett flygplan med registreringsnummer {this._registry}, färgen {this._colour}, {this._seatCount} säten, {this._engineCount} motorer och ett vingspann på {this._wingspan} meter";
    }
}