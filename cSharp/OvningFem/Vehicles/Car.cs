namespace OvningFem.Vehicles;

class Car : Vehicle
{
    private int _wheelCount;
    private bool _sunroof;

    public Car(string Colour, int SeatCount, string Registry, string Propulsion, int WheelCount, bool Sunroof)
    {
        this.Colour = Colour;
        this.SeatCount = SeatCount;
        this.Registry = Registry;
        this.Propulsion = Propulsion;
        this.WheelCount = WheelCount;
        this.Sunroof = Sunroof;
    }

    public int WheelCount
    {
        get
        {
            return this._wheelCount;
        }
        init
        {
            this._wheelCount = WheelCount;
        }
    }

//TODO make HasSunRoof
    public bool Sunroof
    {
        get
        {
            return this._sunroof;
        }
        init
        {
            this._sunroof = Sunroof;
        }
    }
}