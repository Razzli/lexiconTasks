using OvningNio.Model.Vehicles;
namespace OvningNio.Model.Garage;

interface IGarage<T> where T : Vehicle
{
    int Size {get;}
    int FreeSpace {get;}
    int UsedSpace {get;}
    List<T> Storage {get;}
    public bool Add(T Target);

    public bool Remove(T Target);

}