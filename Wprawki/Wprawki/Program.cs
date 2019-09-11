using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wprawki
{
    class Program
    {
        static void Main1(string[] args)
        {
            int x = int.MaxValue;
            int y = 2;
            int z = x + y;
            Console.WriteLine(z);
            Console.ReadKey();

            checked
            {
                z = x + y;
            }
        }

        static void Main3(string[] args)
        {
            double x = 0.1;
            double y = 0.2;
            double z = 0.3;
            Console.WriteLine(x + y == z);

            decimal xx = 0.1m;
            float yy = 0.1f;      //literal typu float

            decimal suma = 0;
            for (int i = 1; i <= 1000000; i++) //milion razy wykonaj
            {
                suma = suma + xx; //sumuj akumulacyjnie
            }
            Console.WriteLine(suma);
        }
            static void Main6(string[] args)
            {
            char znak = 'a';
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine( (char)(znak + i) );
            }

            string napis = "a";
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(napis + i);
            }

            string napis1 = "ala ma kota";


            for (int i = napis1.Length-1; i >= 0; i--)
            {
                Console.Write(napis1[i]);
            }




        }
        static void Main(string[] args)
        {
            int x = -7, y = 5;
            int z = 0;
            int u = x;
            do
            {
                z = z + y;
                Console.WriteLine(z);
                u = u - 1;
            } while (u!=0);
            Console.WriteLine("wynik");
            Console.WriteLine(z);
            Console.ReadKey();





        }
    }
}
