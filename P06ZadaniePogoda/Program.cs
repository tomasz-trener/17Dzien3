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
            Console.WriteLine("POdaj miasto");
            string miasto = Console.ReadLine();

            Console.WriteLine("Podaj jednostke w jakiej chcesz otrzymać wynik. " +
                "Możliwe jednostki to f - farenheit, c - celcjusz lub k - kelvin");

            ManagerPogody mp = new ManagerPogody();
            mp.Jednostka = Console.ReadLine();

            double wynik= mp.PodajTemperature("warszawa");

            Console.WriteLine(wynik);
            Console.ReadKey();
        }
    }
}
