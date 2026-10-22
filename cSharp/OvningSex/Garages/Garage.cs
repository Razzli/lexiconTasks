using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using OvningSex.Vehicles;

namespace OvningSex.Garages;

class Garage
{
    private List<Vehicle> _storage = new List<Vehicle>();
    private int _size;
    private Dictionary<Type, int> _typeCount = new Dictionary<Type, int>();
    
    public Garage(int Size)
    {
        this._size = Size;
    }

    public Garage(int Size, List<Vehicle> Vehicles)
    {
        this._size = Size;
        _storage.Append<Vehicle>(Vehicles.GetRange(0, Vehicles.Count()));
        //Count();
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

    public Dictionary<Type, int> GetCount()
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
        //Lambda function that finds the vehicle with the correct registry and returns it
        return _storage.Find(Vehicle => Vehicle.Registry == Registry) ?? throw new ArgumentException("Registry does not exist");
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
           if (_typeCount.ContainsKey(Target.GetType())) _typeCount[Target.GetType()]++;
           else _typeCount.Add(Target.GetType(), 1); 
        }
        else
        {
            _typeCount[Target.GetType()]--;
            if (_typeCount[Target.GetType()] == 0) _typeCount.Remove(Target.GetType());
        }
    }

//NOT IMPLEMENTED YET
    public void Sort(int type)
    {
        for (int i = 0; i < _storedVehiclesAmount-1; i++)
        {
            for (int j = i+1; j < _storedVehiclesAmount; j++)
            {
                if (type == 1)
                {
                    
                }
                else if (type == 2)
                {
                    
                }
                else if (type == 3)
                {
                    
                }
            }
        }
    }
    
}