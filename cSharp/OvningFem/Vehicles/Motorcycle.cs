namespace OvningFem.Vehicles;

class Motorcycle : Vehicle
{
    private bool _storageCompartment;

    public Motorcycle(string Colour, int SeatCount, string Registry, string Propulsion, bool StorageCompartment)
    {
        this.Colour = Colour;
        this.SeatCount = SeatCount;
        this.Registry = Registry;
        this.Propulsion = Propulsion;
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
}