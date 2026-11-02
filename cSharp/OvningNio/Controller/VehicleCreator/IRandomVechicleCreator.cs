using OvningNio.Model.Garage;
using OvningNio.Model.Vehicle;

namespace OvningNio.Controller.VehicleCreator;

interface IRandomVechicleCreator
{
    public Vehicle Create(Garage<Vehicle> Storage);
}