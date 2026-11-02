using OvningNio.Model.Vehicle;
using OvningNio.Model.Garage;

namespace OvningNio.Controller;

//This is Controller
interface IGarageHandler
{
    Garage<Vehicle> EGarageCreator();
    Garage<Vehicle> GarageCreator();
    Garage<Vehicle> RGarageCreator();
    Vehicle RegistryFind();

    void VehicleAdd(Garage<Vehicle> Storage);
    void VehicleRemove(Garage<Vehicle> Storage);
    bool VehicleSearch(Garage<Vehicle> Storage);
    void VehicleSort(Garage<Vehicle> Storage);
    void ListVehicles(Garage<Vehicle> Storage);
    void ListVehicleTypes(Garage<Vehicle> Storage);

}