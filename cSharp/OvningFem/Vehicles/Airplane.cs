namespace OvningFem.Vehicles;

class Airplane : Vehicle
{
    private int _wingspan;
    private int _engineCount;

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

    public override string ToString()
    {
        return $"Ett flygplan med registreringsnummer {this.Registry}, färgen {this.Colour}, {this.SeatCount} säten, {this.EngineCount} motorer och ett vingspann på {this.Wingspan} meter";
    }
}