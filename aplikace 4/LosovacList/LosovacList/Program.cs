using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosovacList
{
    class Program
    {
        static void Main(string[] args)
        {
            Losovac losovac = new Losovac();
            Console.WriteLine("Vítejte v programu losování.");

            Console.WriteLine("1 - Losovat další číslo");
            Console.WriteLine("2 - Vypsat čísla");
            Console.WriteLine("3 - Konec");
            char volba = '0';
            while (volba != '3')
            {
                volba = Console.ReadKey().KeyChar;
                Console.Clear();
                Console.WriteLine("1 - Losovat další číslo");
                Console.WriteLine("2 - Vypsat čísla");
                Console.WriteLine("3 - Konec");
                Console.WriteLine("");
                switch (volba)
                {
                    case '1':
                        Console.WriteLine("Padlo číslo: {0}", losovac.Losuj());
                        break;
                    case '2':
                        Console.WriteLine("Padla čísla: {0}", losovac.Vypis());
                        Console.WriteLine("Průměr čísel je: {0}", losovac.Prumer());
                        break;
                    case '3':
                        Console.WriteLine("Děkuji za použití programu");
                        break;
                    default:
                        Console.WriteLine("Neplatná volba, zadejte prosím znovu.");
                        break;
                }
            }
        }
    }
}
