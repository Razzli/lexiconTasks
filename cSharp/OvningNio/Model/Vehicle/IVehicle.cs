namespace OvningNio.Model.Vehicle;

interface IVehicle
{
    string Registry {get; set;}
    string Colour {get; set;}
    int SeatCount {get; set;}

    bool CompareRegistry(IVehicle Vehicle);
    bool CompareColour(IVehicle Vehicle);
    bool CompareSeatCount(IVehicle Vehicle);
    string ToString();
    string Localization{get;}
}