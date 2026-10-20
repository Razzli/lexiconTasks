using System.Runtime.InteropServices;

namespace OvningFem.Vehicles;

class Boat : Vehicle
{
    private int _length;
    private int _engineCount;

    public Boat(string Colour, int SeatCount, string Registry, string Propulsion, int Length, int EngineCount)
    {
        this.Colour = Colour;
        this.SeatCount = SeatCount;
        this.Registry = Registry;
        this.Propulsion = Propulsion;
        this.Length = Length;
        this.EngineCount = EngineCount;
    }

    public int Length
    {
        get
        {
            return this._length;
        }
        init
        {
            this._length = Length;
        }
    }

//TODO remove setter
    public int EngineCount
    {
        get
        {
            return this._engineCount;
        }
        init
        {
            this._engineCount = EngineCount;
        }
    }
}