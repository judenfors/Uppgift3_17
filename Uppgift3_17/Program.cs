using System;

namespace uppgift3_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj ett tal");
            float tal1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Välj ett till tal");
            float tal2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Välj en katogori " + "plus, minus, multiplikation eller division");
            string katogori = Console.ReadLine();

            switch (katogori)
            {
                case "plus":
                    float svar = tal1 + tal2;
                    Console.WriteLine("Summan av talen blir " + svar);
                    float.Parse(Console.ReadLine());

                    break;
                case "minus":
                    float svar2 = tal1 - tal2;
                    Console.WriteLine("Differansen av talen blir " + svar2);
                    break;

                case "multiplikation":
                    float svar3 = tal1 * tal2;
                    Console.WriteLine("Produkten av talen blir " + svar3);
                    break;

                case "division":
                    float svar4 = tal1 / tal2;
                    Console.WriteLine("Kvoten av talen blir " + svar4);
                    break;
            }
        }
    }
}