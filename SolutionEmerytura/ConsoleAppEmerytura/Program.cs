using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEmerytura
{
    class Program
    {
        const int wiekEmerytalny = 67;
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikacja emerytura");

            Console.Write("Podaj imie: ");
            string imie = Console.ReadLine();
            Console.WriteLine($"Witaj {imie}");
            Console.Write("Podaj wiek: ");
            int wiek = int.Parse(Console.ReadLine());
            if (wiek < wiekEmerytalny)
            {
                Console.WriteLine($"Zostalo Ci {wiekEmerytalny-wiek} lat do emerytury");
            }
            else
            {
                Console.WriteLine("Jestes emerytem");
            }

            //Console.ReadKey();


            
        }
    }
}
