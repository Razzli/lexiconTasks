using System.Data.SqlTypes;
using OvningSex.Vehicles;

namespace OvningSex.Garages;

class Garage
{
    private List<Vehicle> _storage;
    private int _size;
    private Dictionary<string, int> _typeCount = new Dictionary<string, int>();
    
    public Garage(int Size)
    {
        this._size = Size;
        _storage = new List<Vehicle>(Size);
    }

    public Garage(int Size, List<Vehicle> Vehicles)
    {
        this._size = Size;
        _storage = new List<Vehicle>(Vehicles);
        foreach (Vehicle item in _storage)
        {
            Count(item, true);
        }
    }

    public int GetSize()
    {
        return _size;
    }

    public int GetFreeSpace()
    {
        return _size - _storage.Count;
    }

    public int GetUsedSpace()
    {
        return _storage.Count;
    }

    public Dictionary<string, int> GetCount()
    {
        return _typeCount;
    }

    public void AddVehicle(Vehicle Vehicle)
    {
        if (_storage.Count != _size)
        {
            _storage.Add(Vehicle);
            Count(Vehicle, true);
            Console.WriteLine("Fordon tillagt!");
        }
        else
        {
            throw new IndexOutOfRangeException("Garage cannot contain more vehicles");
        }
    }
    //TODO Remove vehicle by registry
    public void RemoveVehicle(int Index)
    {
        Count(_storage[Index], false);
        _storage.RemoveAt(Index);
        Console.WriteLine("Fordon borttaget!");
    }

    public Vehicle GetVehicleByRegistry(string Registry)
    {
        //Lamer for each function that finds the vehicle with the correct registry
        foreach (Vehicle item in _storage)
        {
            if (item.Registry == Registry) return item;
        }
        throw new ArgumentException("Registry does not exist");
        /**
        Cooler lambda function that finds the vehicle with the correct registry and returns it
        return _storage.Find(Vehicle => Vehicle.Registry == Registry) ?? throw new ArgumentException("Registry does not exist");
        **/
    }

    public List<Vehicle> GetStorage()
    {
        //Copies the list and returns it, fancier version of new List<Vehicle>(_storage) for maximum confusion
        return [.. _storage];
    }

    private void Count(Vehicle Target, bool ToAdd)
    {
        if (ToAdd)
        {
           if (_typeCount.ContainsKey(Target.Localization)) _typeCount[Target.Localization]++;
           else _typeCount.Add(Target.Localization, 1); 
        }
        else
        {
            _typeCount[Target.Localization]--;
            if (_typeCount[Target.Localization] == 0) _typeCount.Remove(Target.Localization);
        }
    }

//A bit slow but works
    public void Sort(int type)
    {
        Vehicle temp;
        bool flip = false;
        for (int i = 0; i < _storage.Count-1; i++)
        {
            for (int j = i+1; j < _storage.Count; j++)
            {
                if (type == 1 && !_storage[i].CompareColour(_storage[j])) flip = true;
                else if (type == 2 && !_storage[i].CompareSeat(_storage[j])) flip = true;
                else if (type == 3 && !_storage[i].CompareRegistry(_storage[j])) flip = true;
                if (flip)
                {
                    temp = _storage[i];
                    _storage[i] = _storage[j];
                    _storage[j] = temp;
                    flip = false;
                }
            }
        }
    }
    
}