using OvningNio.Model.Garage;
using OvningNio.Model.Vehicle;

namespace OvningNio.Controller.VehicleCreator;

class VehicleCreator : IVehicleCreator, IRandomVechicleCreator
{
    Vehicle IVehicleCreator.Create(Garage<Vehicle> Storage)
    {
        throw new NotImplementedException();
    }

    Vehicle IRandomVechicleCreator.Create(Garage<Vehicle> Storage)
    {
        throw new NotImplementedException();
    }

    
}