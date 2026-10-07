namespace OvningTva
{
    class OvningTva
    {
        public static void Main(string[] args)
        {
            //Variable initialization
            bool done = false;
            string input;

            //Menu in array form, makes it easier to add options
            string[] menu = [
                "Hej och välkommen!\n",
                "Ange menyval nedan:\n",
                "1: ",
                "2: ",
                "0: Avsluta program\n",
                "Ange input: "
            ];


            while (!done)
            {
                //Writes menu
                foreach (string text in menu)
                {
                    Console.Write(text);
                }
                
                //Input reader
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        int temp = AgeCheck();
                        break;
                    case "2":
                        GroupPriceCheck();
                        break;
                    case "3":
                        Loopable();
                        break;
                    case "4":
                        break;
                    case "0":
                        Console.WriteLine("Avslutar!");
                        done = true;
                        break;
                    default:
                        Console.WriteLine("Ogiltigt svar!\n");
                        break;
                }
            }
            
        }

        public static int AgeCheck()
        {
            Console.Write("\nAnge ålder: ");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if (age < 20)
                {
                    Console.WriteLine("Ungdomspris: 80kr");
                    return 80;
                }
                //Borde vara else if men uppgiften kräver nestlad if sats
                else
                {
                    if (age >64)
                    {
                        Console.WriteLine("Pensionärspris: 90kr");
                        return 90;
                    }
                    else
                    {
                        if (age < 5 || age > 100)
                        {
                            return 0;
                        }
                        else
                        {
                            Console.WriteLine("Standardpris: 120kr");
                            return 120;
                        }
                    }
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("FEL! ANGE ÅLDER I INTEGERFORMAT!");
            }
            return -1;
        }

        public static void GroupPriceCheck()
        {
            Console.Write("\nVänligen ange gruppstorlek:");
            try
            {
                int groupSize = Convert.ToInt32(Console.ReadLine());
                int totalCost = 0;

                for (int i = 0; i < groupSize; i++)
                {
                    while (true)
                    {
                        Console.Write($"Gruppmedlem nummer {i+1}");
                        int age = AgeCheck();
                        if (age != -1)
                        {
                            totalCost += age;
                            break;
                        }
                    }
                }
                Console.WriteLine($"Total kostnad för {groupSize} personer är: {totalCost}kr\n");
            }
            catch (System.Exception)
            {
                Console.WriteLine("FEL! ANGE GRUPPSTORLEK I INTEGERFORMAT!");
            }
        }

        public static void Loopable()
        {
            Console.Write("\nAnge text: ");
            string toWrite = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i}. {toWrite} ");
            }
        }

        public static void ThirdWord()
        {
            
        }
        
    }
}