using OvningNio.Model.Garage;
using OvningNio.Model.Vehicles;
using OvningNio.Model.Vehicles.MotorCycle;

namespace OvningNioTests;

public class UnitTest1
{
    //Tests Constructor
    [Fact]
    public void TestEmpty()
    {
        Garage<Vehicle> TestGarage = new Garage<Vehicle>([], 5);
        Assert.Empty(TestGarage);
    }
    //Tests Add and enumerator
    [Fact]
    public void TestAdd()
    {
        Garage<Vehicle> TestGarage = new Garage<Vehicle>([], 5);
        MotorCycle TestCycle = new MotorCycle("abc123", "blå", 2, false);
        TestGarage.Add(TestCycle);
        Assert.Contains(TestCycle, TestGarage.Storage);
    }
    //Size doesn't change
    [Fact]
    public void TestSize()
    {
        Garage<Vehicle> TestGarage = new Garage<Vehicle>([], 5);
        MotorCycle TestCycle = new MotorCycle("abc123", "blå", 2, false);
        TestGarage.Add(TestCycle);
        Assert.Equal(5, TestGarage.Size);
    }
    //Tests Usedspace
    [Fact]
    public void TestUsed()
    {
        Garage<Vehicle> TestGarage = new Garage<Vehicle>([], 5);
        MotorCycle TestCycle = new MotorCycle("abc123", "blå", 2, false);
        TestGarage.Add(TestCycle);
        Assert.Equal(1, TestGarage.UsedSpace);
    }
    //Tests Free space
    [Fact]
    public void TestFree()
    {
        Garage<Vehicle> TestGarage = new Garage<Vehicle>([], 5);
        MotorCycle TestCycle = new MotorCycle("abc123", "blå", 2, false);
        TestGarage.Add(TestCycle);
        Assert.Equal(4, TestGarage.FreeSpace);
    }
    //Tests Remove
    [Fact]
    public void TestRemove()
    {
        Garage<Vehicle> TestGarage = new Garage<Vehicle>([], 5);
        MotorCycle TestCycle = new MotorCycle("abc123", "blå", 2, false);
        TestGarage.Add(TestCycle);
        TestGarage.Remove(TestCycle);
        Assert.Equal(5, TestGarage.FreeSpace);
    }
}
