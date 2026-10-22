namespace OvningSex.Vehicles;

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
        set
        {
            this._sunroof = value;
        }
    }

    public override string ToString()
    {
        if (this._sunroof) return $"En bil med registreringsnummret {this._registry}, färgen {this._colour}, {this._seatCount} säten med talfönster";
        return $"En bil med registreringsnummret {this._registry}, färgen {this._colour}, {this._seatCount} säten utan takfönster";
    }
}