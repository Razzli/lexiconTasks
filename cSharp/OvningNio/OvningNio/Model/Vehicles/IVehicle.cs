namespace OvningNio.Model.Vehicles;

interface IVehicle
{
    string Registry {get; set;}
    string Colour {get; set;}
    int SeatCount {get; set;}

    string ToString();
    string Localization{get;}
}