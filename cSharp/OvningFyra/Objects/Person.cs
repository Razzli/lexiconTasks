
namespace OvningFyra.Objects;
public class Person
{
    private string firstName;
    private string lastName;
    private int age;

    private decimal salary;

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        //Validation
        if (firstName.Length < 3) throw new ArgumentException("First name must contain at least 3 letters");
        if (lastName.Length < 3) throw new ArgumentException("Last name must contain at least 3 letters");
        if (age <= 0) throw new ArgumentException("Age must be more than 0");
        if (salary < 460) throw new ArgumentException("Salary must be more than 460");
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.salary = salary;
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

    public decimal Salary
    {
        get {return this.salary;}
        private set
        {
            this.salary = value;
        }
    }

    public void Bonus(int Increase)
    {
        if (age < 30)
        {
            this.salary += (this.salary/Increase)/2;
        }
        else
        {
            this.salary += (this.salary/Increase);
        }
        
    }

    public override string ToString()
    {
        return $"{firstName} {lastName} receives {salary} dollars";
    }
}