using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02MetodyWKlasach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //https://github.com/tomasz-trener/17Dzien3

            Kalkulator k = new Kalkulator();

            int a=  k.Dodaj(4, 5);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
