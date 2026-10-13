
namespace OvningFyra;
class Program
{
    static void Main(string[] args)
    {
        List<Person> persons = new List<Person>();
        persons.Add(new Person("Bength", "Göran", 4));
        persons.Add(new Person("Bengt", "Göran", 23));
        persons.Add(new Person("Bolof", "Göran", 1));
        persons.Add(new Person("Bength", "Palme", 490));
        persons.Add(new Person("Bength", "Palme", 40));
        persons.OrderBy(p => p.FirstName).ThenBy(p => p.LastName).ThenBy(p => p.Age).ToList().ForEach(p => Console.WriteLine(p.ToString()));
    }
}