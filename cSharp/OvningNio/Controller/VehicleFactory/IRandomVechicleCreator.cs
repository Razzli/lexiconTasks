using OvningNio.Model.Garage;
using OvningNio.Model.Vehicle;

namespace OvningNio.Controller.VehicleFactory;

interface IRandomVechicleCreator
{
    public Vehicle Create(Garage<Vehicle> Storage);
}