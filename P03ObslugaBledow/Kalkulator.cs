using P03ObslugaBledow.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ObslugaBledow
{
    internal class Kalkulator
    {

        private int dodaj(int a, int b)
        {
            return a + b;
        }

        public double WykonajDzialanie(string rowanie) // 6^7
        {
            if(!(rowanie.Contains("+") || rowanie.Contains("-") || rowanie.Contains("*") || rowanie.Contains("/")))
                throw new BadOperatorException();

            // 14+66           100*500+500  //  
            string[] tab1=  rowanie.Split('+'); //[100*500]  
            string[] tab2 = rowanie.Split('-'); //[100*500]
            string[] tab3 = rowanie.Split('*'); //[100] [500]
            string[] tab4 = rowanie.Split('/'); //[100*500]

            

            if (tab1.Length==2)
            {
                // int wynik =Convert.ToInt32(tab1[0]) + Convert.ToInt32(tab1[1]);
                int wynik = dodaj(Convert.ToInt32(tab1[0]), Convert.ToInt32(tab1[1]));
                return wynik;
            }

            if (tab2.Length == 2)
            {
                int wynik = Convert.ToInt32(tab2[0]) - Convert.ToInt32(tab2[1]);
                return wynik;
            }

            if (tab3.Length == 2)
            {
                int wynik = Convert.ToInt32(tab3[0]) * Convert.ToInt32(tab3[1]);
                return wynik;
            }

            if (tab4.Length == 2)
            {
                double wynik = Convert.ToInt32(tab4[0]) / Convert.ToInt32(tab4[1]);
                return wynik;
            }

            //return "zły operator";
            throw new Exception("Nieznana sytuacja - szczegółowe informacje dla programisty ");

        }


        public void WykonajDzialanie2(string rownanie)
        {
            // 14+66           100*500+500  //  
            string[] tab1 = rownanie.Split('+'); //[100*500]  
            string[] tab2 = rownanie.Split('-'); //[100*500]
            string[] tab3 = rownanie.Split('*'); //[100] [500]
            string[] tab4 = rownanie.Split('/'); //[100*500]


            if (tab1.Length == 2)
            {
                int wynik = Convert.ToInt32(tab1[0]) + Convert.ToInt32(tab1[1]);
                Console.WriteLine(wynik);
            }

            if (tab2.Length == 2)
            {
                int wynik = Convert.ToInt32(tab2[0]) - Convert.ToInt32(tab2[1]);
                Console.WriteLine(wynik);
            }

            if (tab3.Length == 2)
            {
                int wynik = Convert.ToInt32(tab3[0]) * Convert.ToInt32(tab3[1]);
                Console.WriteLine(wynik);
            }

            if (tab4.Length == 2)
            {
                double wynik = Convert.ToInt32(tab4[0]) / Convert.ToInt32(tab4[1]);
                Console.WriteLine(wynik);
            }

            //return "zły operator";
            // throw new Exception("Podano zły operator");
            Console.WriteLine("Podano zły operator");

        }
    }
}
