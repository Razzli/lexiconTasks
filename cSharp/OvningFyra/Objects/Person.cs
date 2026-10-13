using System.Runtime.InteropServices;

namespace OvningFyra;
public class Person
{
    private string firstName;
    private string lastName;
    private int age;

    public Person(string firstName, string lastName, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }

    public string FirstName
    {
        get {return this.firstName;}
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Namn kan inte vara tomt");
            }
            else
            {
                this.firstName = value;
            }
        }
    }

    public string LastName
    {
        get {return this.lastName;}
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Efternamn kan inte vara tomt");
            }
            else
            {
                this.lastName = value;
            }
        }
    }

    public int Age
    {
        get {return this.age;}
        private set
        {
            this.age = value;
        }
    }

    public override string ToString()
    {
        return $"{firstName} {lastName} is {age} years old";
    }
}