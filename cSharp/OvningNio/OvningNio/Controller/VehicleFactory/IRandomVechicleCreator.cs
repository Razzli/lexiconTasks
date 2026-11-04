using OvningNio.Model.Vehicles;

namespace OvningNio.Controller.VehicleFactory;

interface IRandomVechicleCreator
{
    public Vehicle Create(List<Vehicle> Storage);
}