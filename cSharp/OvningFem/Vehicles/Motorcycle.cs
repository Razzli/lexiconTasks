namespace OvningFem.Vehicles;

class Motorcycle : Vehicle
{
    private bool _storageCompartment;

    public Motorcycle(string Colour, int SeatCount, string Registry, bool StorageCompartment)
    {
        this.Colour = Colour;
        this.SeatCount = SeatCount;
        this.Registry = Registry;
        this.StorageCompartment = StorageCompartment;
    }

//TODO implement hasStorage
    public bool StorageCompartment
    {
        get
        {
            return this._storageCompartment;
        }
        init
        {
            this._storageCompartment = StorageCompartment;
        }
    }

    public override string ToString()
    {
        if (this.StorageCompartment) return $"En motorcykel med registreringsnummret {this.Registry}, färgen {this.Colour}, {this.SeatCount} säten med förvaring";
        return $"En motorcykel med registreringsnummret {this.Registry}, färgen {this.Colour}, {this.SeatCount} säten utan förvaring";
    }
}