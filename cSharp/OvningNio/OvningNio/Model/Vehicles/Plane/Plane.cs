namespace OvningNio.Model.Vehicles.Plane;

public class Plane : Vehicle, IPlane
{
    private int _wingSpan;
    private int _engineCount;
    private readonly string _localization = "flygplan";

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

    public override string Localization => _localization;

    public override string ToString()
    {
        return $"Ett {Colour} flygplan med registreringsnummret {Registry}, {SeatCount} säten, {EngineCount} motorer och ett vingspann på {Wingspan} meter.";
    }
}