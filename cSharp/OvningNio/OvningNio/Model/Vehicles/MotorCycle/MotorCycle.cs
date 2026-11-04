namespace OvningNio.Model.Vehicles.MotorCycle;

public class MotorCycle : Vehicle, IMotorCycle
{
    private bool _storageCompartment;
    private readonly string _localization = "Motorcykel";

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

    public override string Localization => _localization;

    public override string ToString()
    {
        if (StorageCompartment) return $"En {Colour} motorcykel med registreringen {Registry}, {SeatCount} säten med förvaring";
        return $"En {Colour} motorcykel med registreringen {Registry}, {SeatCount} säten utan förvaring";
    }
}