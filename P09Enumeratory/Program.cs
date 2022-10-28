using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09Enumeratory
{
    internal class Program
    {
        static void Main(string[] args)
        {

          //  int a = 5;
          //  int? b = a;


            //int? c = 5;
          //  int d = (int) c;

            //  Console.WriteLine()
 
            Console.WriteLine("Podaj jednostke w jakiej chcesz otrzymać wynik. " +
               "Możliwe jednostki to f - farenheit, c - celcjusz lub k - kelvin");

            Jednostka? jd=null;

            while (jd==null)
            {
                string jednostka = Console.ReadLine();
                if (jednostka == "c")
                    jd = Jednostka.Celcjusz;
                else if (jednostka == "k")
                    jd = Jednostka.Kelvin;
                else if (jednostka == "f")
                    jd = Jednostka.Farenheit;
                else
                    Console.WriteLine("podano nieznaną jednostkę. Podaj jeszcze raz");
            }
 
            ManagerPogody mp = new ManagerPogody((Jednostka)jd, "°");
            double wyn =mp.PodajTemperature("warszawa");
            Console.WriteLine(wyn);
            Console.ReadKey();
        }
    }
}
