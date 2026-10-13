namespace ExempelEncapslation
{
    class ExempelEncapsulation
    {
        static void Main(string[] args)
        {
            CityGet ExampleGet = new CityGet("test");
            CityRead ExampleRead = new CityRead("testRead");

            ExampleGet.Name = "testChange";

            Console.WriteLine(ExampleGet.Name);
            Console.WriteLine(ExampleRead.Name);
        }
    }

    public class CityGet
    {
        public string Name { get; }

        public CityGet (string name) 
        {
            Name = name;
        }
    }

    public class CityRead
    {
        public readonly string Name;

        public CityRead (string name){
            Name = name;
        }
    }
}