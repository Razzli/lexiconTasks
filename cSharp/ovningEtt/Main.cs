using System;

namespace ovningEtt
{
    class ovningEtt
    {
        static void Main(string[] args)
        {
            List<Arbetare> arbetare = new List<Arbetare>();
            Console.WriteLine("Startar Registersystem 1.0");
            bool cont = true;

            while (cont)
            {
                Console.WriteLine("Vänligen ange val:");
                Console.WriteLine("1. Lägg till arbetare");
                Console.WriteLine("2. Visa arbetarlista");
                Console.WriteLine("3. Avsluta");
                Console.Write("Inväntar input: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Ange namn: ");
                        String namn = Console.ReadLine();
                        Console.Write("Ange lön: ");
                        String input= Console.ReadLine();
                        try
                        {
                            int lon = Convert.ToInt32(input);
                            arbetare.Add(new Arbetare(){Namn = namn, Lon = lon});
                            Console.WriteLine("Lägger till ny arbetare, " + namn + "med lönen " + input + "kr");
                        }
                        catch (System.Exception)
                        {
                            Console.WriteLine("Fel, ange lönen i integerformat.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Skriver ut alla " + Convert.ToString(arbetare.Count) + " arbetare:");
                        foreach (Arbetare person in arbetare)
                        {
                            Console.WriteLine(person.ToString());
                        }
                        break;
                    case "3":
                        Console.WriteLine("Avslutar");
                        cont = false;
                        break;
                    default:
                        Console.WriteLine("Ogiltigt svar");
                        break;
                }
            }
        }
    }

    public class Arbetare
    {
        public string Namn { get; set; }
        public int Lon { get; set; }

        public override string ToString()
        {
            return Namn + ", Lön: " + Convert.ToString(Lon);
        }
    }
}