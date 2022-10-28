using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadanieKlasy
{
    internal class Kalkulator
    {
        public double WykonajDzialanie(string rowanie) // 6^7
        {
            // 14+66           100*500+500  //  
            string[] tab1=  rowanie.Split('+'); //[100*500]  
            string[] tab2 = rowanie.Split('-'); //[100*500]
            string[] tab3 = rowanie.Split('*'); //[100] [500]
            string[] tab4 = rowanie.Split('/'); //[100*500]


            if (tab1.Length==2)
            {
                int wynik =Convert.ToInt32(tab1[0]) + Convert.ToInt32(tab1[1]);
                return wynik;
            }

            if (tab2.Length == 2)
            {
                int wynik = Convert.ToInt32(tab1[0]) - Convert.ToInt32(tab1[1]);
                return wynik;
            }

            if (tab3.Length == 2)
            {
                int wynik = Convert.ToInt32(tab1[0]) * Convert.ToInt32(tab1[1]);
                return wynik;
            }

            if (tab4.Length == 2)
            {
                double wynik = Convert.ToInt32(tab1[0]) / Convert.ToInt32(tab1[1]);
                return wynik;
            }

            //return "zły operator";
            throw new Exception("Podano zły operator");

        }
    }
}
