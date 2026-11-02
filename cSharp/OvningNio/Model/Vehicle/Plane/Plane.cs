namespace OvningNio.Model.Vehicle.Plane;

class Plane : Vehicle, IPlane
{
    private int _wingSpan;
    private int _engineCount;

    public Plane(string Registry, string Colour, int SeatCount, int Wingspan, int EngineCount)
    {
        this.Registry = Registry;
        this.Colour = Colour;
        this.SeatCount = SeatCount;
        this.Wingspan = Wingspan;
        this.EngineCount = EngineCount;
    }
    public int Wingspan{
        get => _wingSpan;
        set => _wingSpan = value;
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