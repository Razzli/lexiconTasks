using System.Runtime.InteropServices;

namespace OvningFem.Vehicles;

class Boat : Vehicle
{
    private int _length;
    private int _engineCount;

    public Boat(string Colour, int SeatCount, string Registry, int Length, int EngineCount)
    {
        this.Colour = Colour;
        this.SeatCount = SeatCount;
        this.Registry = Registry;
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

    public override string ToString()
    {
        return $"En båt med registreringen {this.Registry}, färgen {this.Colour}, {this.SeatCount} säten, längden {this.Length} och {EngineCount} motorer";
    }
}