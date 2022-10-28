using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08KonstruktoryPogoda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj miasto");
            string miasto = Console.ReadLine();

            Console.WriteLine("Podaj jednostke w jakiej chcesz otrzymać wynik. " +
                "Możliwe jednostki to f - farenheit, c - celcjusz lub k - kelvin");

            string jednostka = Console.ReadLine();
            ManagerPogody mp = new ManagerPogody(jednostka, "°");
           // mp.Jednostka = Console.ReadLine();
           // mp.SzukanyZnak = "°";

            double wynik = mp.PodajTemperature("warszawa");

            // po jakimś czasie 

            //ManagerPogody mp2 = new ManagerPogody("k", "°");
            //double wynik2= mp2.PodajTemperature("warszawa");

            //string x = mp.Jednostka;
            
            mp.Jednostka = "k";
            mp.PodajTemperature("warszawa");

            Console.WriteLine(wynik);
            Console.ReadKey();
        }
    }
}
