namespace OvningNio.Model.Vehicles.Car;

class Car : Vehicle, ICar
{
    private bool _sunRoof;
    private readonly string _localization = "bil";

    public Car(string Registry, string Colour, int SeatCount, bool SunRoof)
    {
        this.Registry = Registry;
        this.Colour = Colour;
        this.SeatCount = SeatCount;
        this.SunRoof = SunRoof;
    }
    public bool SunRoof
    {
        get => _sunRoof;
        set => _sunRoof = value;
    }

    public override string Localization => _localization;

    public override string ToString()
    {
        if (SunRoof) return $"En {Colour} bil med registreringen {Registry}, {SeatCount} säten med soltak";
        return $"En {Colour} bil med registreringen {Registry}, {SeatCount} säten utan soltak";
    }
}