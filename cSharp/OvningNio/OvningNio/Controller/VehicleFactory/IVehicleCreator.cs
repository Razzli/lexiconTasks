using OvningNio.Model.Garage;
using OvningNio.Model.Vehicles;

namespace OvningNio.Controller.VehicleFactory;

interface IVehicleCreator
{
    public Vehicle Create(List<Vehicle> Storage);
}