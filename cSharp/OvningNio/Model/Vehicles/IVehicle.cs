namespace OvningNio.Model.Vehicles;

interface IVehicle
{
    string Registry {get; set;}
    string Colour {get; set;}
    int SeatCount {get; set;}

    static abstract int CompareRegistry(IVehicle Vehicle1, IVehicle Vehicle2);
    static abstract int CompareColour(IVehicle Vehicle1, IVehicle Vehicle2);
    static abstract int CompareSeatCount(IVehicle Vehicle1, IVehicle Vehicle2);
    string ToString();
    string Localization{get;}
}