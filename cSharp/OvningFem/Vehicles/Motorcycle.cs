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
        set
        {
            this._storageCompartment = value;
        }
    }

    public override string ToString()
    {
        if (this._storageCompartment) return $"En motorcykel med registreringsnummret {this._registry}, färgen {this._colour}, {this._seatCount} säten med förvaring";
        return $"En motorcykel med registreringsnummret {this._registry}, färgen {this._colour}, {this._seatCount} säten utan förvaring";
    }
}