namespace OvningNio.Model.Vehicle.Car;

class Car : Vehicle, ICar
{
    private bool _sunRoof;

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

    public override string Localization => throw new NotImplementedException();

    public override string ToString()
    {
        throw new NotImplementedException();
    }
}