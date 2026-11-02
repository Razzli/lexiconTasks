namespace OvningNio.Model.Garage;

class Garage<T> : IGarage<T>
{
    private readonly int _size;
    private List<T> _storage;

    public Garage(List<T> Storage, int Size)
    {
        this._size = Size;
        _storage = [.. Storage];
    }

    public int Size => _size;
    

    public List<T> Storage => [.. _storage];

    public int FreeSpace => _size - _storage.Count;

    public bool AddVehicle()
    {
        throw new NotImplementedException();
    }

    public bool RemoveVehicle()
    {
        throw new NotImplementedException();
    }

    public void Sort()
    {
        throw new NotImplementedException();
    }
}