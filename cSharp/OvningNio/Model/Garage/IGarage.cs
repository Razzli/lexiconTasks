namespace OvningNio.Model.Garage;

interface IGarage<T>
{
    int Size {get;}
    int FreeSpace {get;}

    List<T> Storage {get;}

    public bool AddVehicle();

    public bool RemoveVehicle();

    public void Sort();

}