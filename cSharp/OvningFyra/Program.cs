using OvningFyra.Objects;

namespace OvningFyra;
class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();
        Console.Write("Amount of employees to add: ");
        int lines = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            string[] arguments = Console.ReadLine().Split(" ");
            try
            {
                people.Add(new Person(arguments[0], arguments[1], Convert.ToInt32(arguments[2]), Convert.ToDecimal(arguments[3])));
            }
            catch (System.ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Wrong format on integer or decimal input");
            }
            
            
        }
        Console.Write("Give bonus in integerformat: ");
        int bonus = Convert.ToInt32(Console.ReadLine());
        foreach (Person person in people)
        {
            person.Bonus(bonus);
            Console.WriteLine(person.ToString());
        }
    }
}