namespace OvningNio.Model.Vehicle.MotorCycle;

class MotorCycle : Vehicle, IMotorCycle
{
    private bool _storageCompartment;

    public MotorCycle(string Registry, string Colour, int SeatCount, bool StorageCompartment)
    {
        this.Registry = Registry;
        this.Colour = Colour;
        this.SeatCount = SeatCount;
        this.StorageCompartment = StorageCompartment;
    }
    public bool StorageCompartment {
        get => _storageCompartment;
        set => _storageCompartment = value;
    }

    public override string Localization => throw new NotImplementedException();

    public override string ToString()
    {
        throw new NotImplementedException();
    }
}