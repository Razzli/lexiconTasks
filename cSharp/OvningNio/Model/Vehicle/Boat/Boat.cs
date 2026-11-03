namespace OvningNio.Model.Vehicle.Boat;

class Boat : Vehicle, IBoat
{
    private int _length;
    private int _engineCount;
    private readonly string _localization = "båt";

    public Boat(string Registry, string Colour, int SeatCount, int Length, int EngineCount)
    {
        this.Registry = Registry;
        this.Colour = Colour;
        this.SeatCount = SeatCount;
        this.Length = Length;
        this.EngineCount = EngineCount;
    }
    public int Length
    {
        get => _length;
        set => _length = value;
    }
    public int EngineCount{
        get => _engineCount;
        set => _engineCount = value;
    }

    public override string Localization => _localization;

    public override string ToString()
    {
        return $"En {Length} lång, {Colour} båt med registreringen {Registry}, {SeatCount} säten och {EngineCount} motorer";
    }
}