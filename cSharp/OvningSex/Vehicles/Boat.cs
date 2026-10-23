namespace OvningSex.Vehicles;

class Boat : Vehicle
{
    private int _length;
    private int _engineCount;
     //Used as an identifier for the typecount function in Controller
    private readonly string _localization = "båt";

    public Boat(string Colour, int SeatCount, string Registry, int Length, int EngineCount)
    {
        this.Colour = Colour;
        this.SeatCount = SeatCount;
        this.Registry = Registry;
        this.Length = Length;
        this.EngineCount = EngineCount;
    }

    public int Length
    {
        get
        {
            return this._length;
        }
        set
        {
            this._length = value;
        }
    }


    public int EngineCount
    {
        get
        {
            return this._engineCount;
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
        return $"En båt med registreringen {this._registry}, färgen {this._colour}, {this._seatCount} säten, längden {this._length} och {_engineCount} motorer";
    }
}