using OvningNio.Model.Garage;
using OvningNio.Model.Vehicle;

namespace OvningNio.Controller.VehicleFactory;

interface IVehicleCreator
{
    public Vehicle Create(Garage<Vehicle> Storage);
}