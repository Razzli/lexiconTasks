using System.Diagnostics;
using OvningFem.Vehicles;

namespace OvningFem.Garages;

class Garage
{
    //Reinventing arrays at first principles
    private Vehicle[] _storage;
    private int _storedVehiclesAmount = 0;
    
    public Garage(int Size)
    {
        _storage = new Vehicle[Size];
    }

    public Garage(int Size, Vehicle[] Vehicles)
    {
        _storage = new Vehicle[Size];
        Array.Copy(Vehicles, _storage, Vehicles.Length);
    }

    public int GetSize()
    {
        return _storage.Length;
    }

    public int GetFreeSpace()
    {
        return _storage.Length - _storedVehiclesAmount;
    }

    public int GetUsedSpace()
    {
        return _storedVehiclesAmount;
    }

    public void AddVehicle(Vehicle Vehicle)
    {
        if (_storedVehiclesAmount != _storage.Length - 1)
        {
            _storage[_storedVehiclesAmount] = Vehicle;
            _storedVehiclesAmount++;
        }
        else
        {
            throw new IndexOutOfRangeException("Garage cannot contain more vehicles");
        }
    }

    public void RemoveVehicle(int Index)
    {
        _storage[Index] = _storage[_storedVehiclesAmount-1];
        _storedVehiclesAmount--;
    }

    public Vehicle GetVehicleByRegistry(string Registry)
    {
        for (int i = 0; i < _storedVehiclesAmount; i++)
        {
            if (_storage[i].Registry == Registry) return _storage[i]; 
        }
        throw new ArgumentException("Registry does not exist");
    }

    public Vehicle[] GetStorage()
    {
        Vehicle[] Storage = new Vehicle[_storedVehiclesAmount];
        Array.Copy(_storage, new Vehicle[_storedVehiclesAmount], _storedVehiclesAmount);
        return Storage;
    }

    private void Count()
    {
        for (int i = 0; i < _storedVehiclesAmount; i++)
        {
            switch (_storage[i])
            {
                case Airplane:
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Garage count broke somehow");
            }
        }
    }

    
}