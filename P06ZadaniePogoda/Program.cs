using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06ZadaniePogoda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagerPogody mp = new ManagerPogody();
            mp.Jednostka = "f";

            double wynik= mp.PodajTemperature("warszawa");

            Console.WriteLine(wynik);
            Console.ReadKey();
        }
    }
}
