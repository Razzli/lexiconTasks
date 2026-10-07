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
                        AgeCheck();
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

        public void AgeCheck()
        {
            
        }

        
    }
}