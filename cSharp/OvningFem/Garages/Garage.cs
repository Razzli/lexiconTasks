using OvningFem.Vehicles;

namespace OvningFem.Garages;

class Garage
{
    //Reinventing lists at first principles
    private Vehicle[] _storage;
    private int _storedVehiclesAmount = 0;
    private int[] _typeCount = [0,0,0,0,0];
    
    public Garage(int Size)
    {
        _storage = new Vehicle[Size];
    }

    public Garage(int Size, Vehicle[] Vehicles)
    {
        _storage = new Vehicle[Size];
        Array.Copy(Vehicles, _storage, Vehicles.Length);
        Count();
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

    public int[] GetCount()
    {
        return _typeCount;
    }

    public void AddVehicle(Vehicle Vehicle)
    {
        if (_storedVehiclesAmount != _storage.Length - 1)
        {
            _storage[_storedVehiclesAmount] = Vehicle;
            _storedVehiclesAmount++;
            Count();
            Console.WriteLine("Fordon tillagt!");
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
        Count();
        Console.WriteLine("Fordon borttaget!");
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
        int[] TypeCount = [0,0,0,0,0];
        for (int i = 0; i < _storedVehiclesAmount; i++)
        {
            switch (_storage[i])
            {
                case Airplane:
                    TypeCount[0] ++;
                    break;
                case Boat:
                    TypeCount[1] ++;
                    break;
                case Bus:
                    TypeCount[2] ++;
                    break;
                case Car:
                    TypeCount[3] ++;
                    break;
                case Motorcycle:
                    TypeCount[4] ++;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Garage count broke somehow");
            }
        }
        this._typeCount = TypeCount;
    }

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