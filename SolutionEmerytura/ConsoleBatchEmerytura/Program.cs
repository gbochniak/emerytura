using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBatchEmerytura
{
    class Program
    {
        const int wiekEmerytalny = 67;
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikacja emerytura");

            if(args.Length != 2)
            {
                Console.WriteLine("Brak danych. Koniec");
                return;

            }
            string imie = args[0];
            Console.WriteLine($"Witaj {imie}");
           
            int wiek = int.Parse(args[1]);
            if (wiek < wiekEmerytalny)
            {
                Console.WriteLine($"Zostalo Ci {wiekEmerytalny - wiek} lat do emerytury");
            }
            else
            {
                Console.WriteLine("Jestes emerytem");
            }

            //Console.ReadKey();



        }
    }
}
