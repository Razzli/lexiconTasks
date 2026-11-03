namespace OvningNio.Model.Vehicles.Bus;

class Bus : Vehicle, IBus
{
    private bool _roofAccess;
    private int _wheelCount;
    private string _localization = "buss";

    public Bus (string Registry, string Colour, int SeatCount, bool RoofAccess, int WheelCount)
    {
        this.Registry = Registry;
        this.Colour = Colour;
        this.SeatCount = SeatCount;
        this.RoofAccess = RoofAccess;
        this.WheelCount = WheelCount;
    }
    public bool RoofAccess{
        get => _roofAccess;
        set => _roofAccess = value;
    }
    public int WheelCount{
        get => _wheelCount;
        set => _wheelCount = value;
    }

    public override string Localization => _localization;

    public override string ToString()
    {
        if (RoofAccess) return $"En {Colour} Motorcykel med registreringen {Registry}, {SeatCount} säten, {WheelCount} hjul med takaccess";
        return $"En {Colour} Motorcykel med registreringen {Registry}, {SeatCount} säten, {WheelCount} hjul utan takaccess";
    }
}