using OvningNio.Model.Vehicles;
using OvningNio.Model.Garage;

namespace OvningNio.Controller;

//This is Controller
interface IGarageHandler
{
    Garage<Vehicle> EGarageCreator();
    Garage<Vehicle> GarageCreator();
    Garage<Vehicle> RGarageCreator();
    void RegistryFind(Garage<Vehicle> Storage);
    void VehicleAdd(Garage<Vehicle> Storage);
    void VehicleRemove(Garage<Vehicle> Storage);
    void VehicleSearch(Garage<Vehicle> Storage);
    void ListVehicles(Garage<Vehicle> Storage);
    void ListVehicleTypes(Garage<Vehicle> Storage);

}