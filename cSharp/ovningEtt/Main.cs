using System;

namespace ovningEtt
{
    class ovningEtt
    {
        static void Main(string[] args)
        {
            //Arbetarlista, använder arbetarclassen nedan
            List<Arbetare> arbetare = new List<Arbetare>();
            Console.WriteLine("Startar Registersystem 1.0");

            //While loop, används som klockcykel för programmet
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

                        //Felhantering, ser till att lönen blir skriven i integerformat
                        try
                        {
                            int lon = Convert.ToInt32(input);
                            arbetare.Add(new Arbetare(){Namn = namn, Lon = lon});
                            Console.WriteLine("Lägger till ny arbetare, " + namn + " med lönen " + input + "kr");
                        }
                        catch (System.Exception)
                        {
                            Console.WriteLine("Fel, ange lönen i integerformat.");
                        }
                        break;
                    case "2":
                        //Ser till att det faktiskt finns arbetare
                        if (arbetare.Count != 0)
                        {
                            //For each för att skriva ut mängden arbetare
                            Console.WriteLine("Skriver ut alla " + Convert.ToString(arbetare.Count) + " arbetare:");
                            foreach (Arbetare person in arbetare)
                            {
                                Console.WriteLine(person.ToString());
                            }
                        }
                        else { Console.WriteLine("FEL! Arbetarlista tom"); }
                        break;
                    case "3":
                        Console.WriteLine("Avslutar");
                        //Avslutar
                        cont = false;
                        break;
                    default:
                        //Edgecase hantering
                        Console.WriteLine("Ogiltigt svar");
                        break;
                }
            }
        }
    }

    public class Arbetare
    {
        //Getters och setters, hade jag gjort detta i java hade dessa variabler vart privata
        public string Namn { get; set; }
        public int Lon { get; set; }

        //Enkel tostring funktion
        public override string ToString()
        {
            return Namn + ", Lön: " + Convert.ToString(Lon);
        }
    }
}