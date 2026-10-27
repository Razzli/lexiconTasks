using System.IO.Compression;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace LinqOvningar;
public class Student 
{ 
    public int Id { get; set; } 
    public string Namn { get; set; } = "";
    public int Alder { get; set; } 
    public string Klass { get; set; } = "";
    public int Poang { get; set; } 
} 
class Program 
{ 
    static void Main(string[] args) 
    {
        // Exempeldata 
        List<Student> studenter = new List<Student> 
        {
            new Student { Id = 1, Namn = "Anna", Alder = 19, Klass = "A", Poang = 85 }, 
            new Student { Id = 2, Namn = "Bertil", Alder = 22, Klass = "B", Poang = 72 }, 
            new Student { Id = 3, Namn = "Cecilia", Alder = 20, Klass = "A", Poang = 91 }, 
            new Student { Id = 4, Namn = "David", Alder = 24, Klass = "C", Poang = 64 }, 
            new Student { Id = 5, Namn = "Eva", Alder = 19, Klass = "B", Poang = 85 }, 
            new Student { Id = 6, Namn = "Felix", Alder = 21, Klass = "A", Poang = 77 }, 
            new Student { Id = 7, Namn = "Gustav", Alder = 23, Klass = "C", Poang = 58 }, 
            new Student { Id = 8, Namn = "Hanna", Alder = 20, Klass = "B", Poang = 95 } 
        }; 
        Console.WriteLine("LINQ-ÖVNINGAR MED STUDENTER\n");

        Console.WriteLine("Alla studenter äldre än 20:");
        var oldStudents = studenter.Where(Student => Student.Alder > 20).Select(Student => Student.Namn);
        foreach (var item in oldStudents)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Alla studenter med mer poäng än 80");
        var scoringStudents = studenter.Where(Student => Student.Poang > 80).Select(Student => Student.Namn);
        foreach (var item in scoringStudents)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Alla studenters namn");
        var studentNames = studenter.Select(Student => Student.Namn);
        foreach (var item in studentNames)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Alla studenters namn och poäng");
        var studentTuples = studenter.Select(Student => new {Name = Student.Namn, Poang = Student.Poang});
        foreach (var item in studentTuples)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Alla Studenter ordnade efter ålder");
        var studentAgeOrder = studenter.OrderBy(Student => Student.Alder).Select(Student => new {Name = Student.Namn, Alder = Student.Alder});
        foreach (var item in studentAgeOrder)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine("Alla Studenter ordnade efter Poäng");
        var studentPointOrder = studenter.OrderBy(Student => Student.Poang).Select(Student => new {Name = Student.Namn, Poang = Student.Poang}).Reverse();
        foreach (var item in studentPointOrder)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Hur många studenter finns det?");
        var studentCount = studenter.Count();
        Console.WriteLine($"{studentCount}");

        Console.WriteLine("Hur många studenter gåt i klass A");
        var classACount = studenter.Where(Student => Student.Klass == "A").Count();
        Console.WriteLine($"{classACount}");

        Console.WriteLine("De tre första studenterna");
        var threeFirstStudents = studenter.Take(3).Select(Student => Student.Namn);
        foreach (var item in threeFirstStudents)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("De två bästa studenterna");
        var bestStudents = studenter.OrderBy(Student => Student.Poang).Reverse().Take(2).Select(Student => new {Namn = Student.Namn, Poang = Student.Poang});
        foreach (var item in bestStudents)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Alla klassnamn");
        var classes = studenter.Select(Student => Student.Klass).Distinct();
        foreach (var item in classes)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Alla åldrar");
        var ages = studenter.Select(Student => Student.Alder).Distinct();
        foreach (var item in ages)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Finns det någon med perfekt score?");
        var perfect = studenter.Any(Student => Student.Poang == 100);
        Console.WriteLine(perfect);

        Console.WriteLine("Har alla studenter minst 50 poäng?");
        var points = studenter.All(Student => Student.Poang >= 50);
        Console.WriteLine(points);

        Console.WriteLine("Första studenten i klassen B");
        var bStudent = studenter.Where(Student => Student.Klass == "B").Select(Student => Student.Namn).FirstOrDefault();
        Console.WriteLine(bStudent);

        Console.WriteLine("Sista studenten i listan");
        var lStudent = studenter.Select(Student => Student.Namn).Last();
        Console.WriteLine(lStudent);

        Console.WriteLine("Student med visst id");
        var sStudent = studenter.Where(Student => Student.Id == 1).Select(Student => Student.Namn).Single();
        Console.WriteLine(sStudent);

        Console.WriteLine("Gruppera studenter");
        var gStudents = studenter.GroupBy(Student => Student.Klass, (classes, ourClass) => new {key = classes, Count = ourClass.Count(), Namn = ourClass.Select(Student => Student.Namn)});
        foreach (var item in gStudents)
        {
            Console.WriteLine($"{item.key}, {item.Count}");
            foreach (var names in item.Namn)
            {
                Console.WriteLine(names);
            }
        }

        Console.WriteLine("Summera poäng");
        var sum = studenter.Select(Student => Student.Poang).Sum();
        Console.WriteLine(sum);

        Console.WriteLine("Medel poäng");
        var mid = studenter.Select(Student => Student.Poang).Average();
        Console.WriteLine(mid);

        Console.WriteLine("Max, Min");
        var max = studenter.Max(Student => Student.Poang);
        var min = studenter.Min(Student => Student.Poang);
        Console.WriteLine($"{max}, {min}");
    }
}