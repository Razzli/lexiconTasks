namespace OvningNio.Model.Vehicle.Bus;

class Bus : Vehicle, IBus
{
    private bool _roofAccess;
    private int _wheelCount;

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

    public override string Localization => throw new NotImplementedException();

    public override string ToString()
    {
        throw new NotImplementedException();
    }
}