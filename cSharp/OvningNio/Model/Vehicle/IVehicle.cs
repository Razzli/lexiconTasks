namespace OvningNio.Model.Vehicle;

interface IVehicle
{
    string Registry {get; set;}
    string Colour {get; set;}
    int SeatCount {get; set;}

    IVehicle CompareRegistry(IVehicle Vehicle);
    IVehicle CompareColour(IVehicle Vehicle);
    IVehicle CompareSeatCount(IVehicle Vehicle);
    string ToString();
    string Localization{get;}
}