using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje2.zad
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("broj: ");
                int broj = 100;
                bool a = true;
                KlasaD suprotnobool = new KlasaD();
                KlasaD suprotnoint = new KlasaD();

                Console.WriteLine("bool" + suprotnobool.suprotnobool(a) + ", broj" + suprotnoint.suprotnoint(broj));
                Console.ReadLine();
            }
        }
    }
}
