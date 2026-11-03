namespace OvningNio.Model.Garage;

interface IGarage<T>
{
    int Size {get;}
    int FreeSpace {get;}

    int UsedSpace {get;}

    List<T> Storage {get;}

    public bool Add(T Target);

    public bool Remove(T Target);

    public void Sort();

}