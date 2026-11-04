using System.Collections;
using OvningNio.Model.Vehicles;
namespace OvningNio.Model.Garage;

public class Garage<T> : IEnumerable<T> where T : Vehicle
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

    public int UsedSpace => _storage.Count;

    public bool Add(T Target)
    {
        if (FreeSpace > 0) _storage.Add(Target);
        else return false;
        return true;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return _storage.GetEnumerator();
    }

    public bool Remove(T Target)
    {
        if (_storage.Contains(Target)) return _storage.Remove(Target);
        else return false;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}