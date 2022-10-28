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
            Kalkulator k = new Kalkulator();

            int a=  k.Dodaj(4, 5);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
