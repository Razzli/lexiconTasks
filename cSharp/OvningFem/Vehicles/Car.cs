namespace OvningFem.Vehicles;

class Car : Vehicle
{
    private bool _sunroof;

    public Car(string Colour, int SeatCount, string Registry, bool Sunroof)
    {
        this.Colour = Colour;
        this.SeatCount = SeatCount;
        this.Registry = Registry;
        this.Sunroof = Sunroof;
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

    public override string ToString()
    {
        if (this.Sunroof) return $"En bil med registreringsnummret {this.Registry}, färgen {this.Colour}, {this.SeatCount} säten med soltak";
        return $"En bil med registreringsnummret {this.Registry}, färgen {this.Colour}, {this.SeatCount} säten utan soltak";
    }
}