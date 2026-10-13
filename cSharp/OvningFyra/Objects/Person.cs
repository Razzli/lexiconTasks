
namespace OvningFyra.Objects;
public class Person
{
    private string firstName;
    private string lastName;
    private int age;

    private decimal salary;

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        //Validation function
        Validate(firstName, lastName, age, salary);
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.salary = salary;
    }

    public string FirstName
    {
        get {return this.firstName;}
        private set{this.firstName = value;}
        
    }

    public string LastName
    {
        get {return this.lastName;}
        private set{this.lastName = value;}
    }

    public int Age
    {
        get {return this.age;}
        private set{this.age = value;}
    }

    public decimal Salary
    {
        get {return this.salary;}
        private set{this.salary = value;}
    }

    public void Bonus(decimal Increase)
    {
        //Turn increase into a percentage
        Increase /= 100;
        if (this.age < 30)
        {
            Increase /= 2;
            this.salary += (this.salary*(Increase));
        }
        else
        {
            this.salary += (this.salary*(Increase));
        }
        
    }

    public void Validate(string firstName, string lastName, int age, decimal salary)
    {
        if (string.IsNullOrWhiteSpace(firstName)) throw new ArgumentException("First name cannot be empty");
        else if (firstName.Length < 3) throw new ArgumentException("First name must contain at least 3 letters");
        
        if (string.IsNullOrWhiteSpace(lastName)) throw new ArgumentException("Last name cannot be empty");
        else if (lastName.Length < 3) throw new ArgumentException("Last name must contain at least 3 letters");
        
        if (age <= 0) throw new ArgumentException("Age must be more than 0");
        
        if (salary < 460) throw new ArgumentException("Salary must be at least 460");
    }

    public override string ToString()
    {
        return $"{firstName} {lastName} receives {salary} dollars";
    }
}