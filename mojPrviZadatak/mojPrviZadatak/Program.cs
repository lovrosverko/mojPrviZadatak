using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mojPrviZadatak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // deklaracija varijabli
            int a, b, x, y;

            // dodjela vrijednosti
            a = 100;
            b = 3;
            x = a / b;
            y = a % b;

            string ispis = a + " dijeljeno s "
                + b + " je " + x + " i ostatak "
                + y;

            // ispisivanje
            Console.WriteLine(ispis);

            Console.ReadKey();



        }
    }
}
