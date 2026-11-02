namespace OvningNio.Model.Vehicle.Boat;

class Boat : Vehicle, IBoat
{
    private int _length;
    private int _engineCount;

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

    public override string Localization => throw new NotImplementedException();

    public override string ToString()
    {
        throw new NotImplementedException();
    }
}