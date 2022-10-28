using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10ZadanieKalkulator
{
    enum Operacja
    {
        Dodawanie,
        Odejmowanie,
        Mnozenie,
        Dzielenie
    }

    internal class Kalkulator
    {
        public double WykonajOperacje(int a, int b, Operacja operacja )
        {
            if (operacja == Operacja.Dodawanie)
            {
                KalkulatorDodajacy kd = new KalkulatorDodajacy();
                return kd.Dodaj(a, b);
            }
               
            if (operacja == Operacja.Odejmowanie)
            {
                KalkulatorOdejmujacy ko = new KalkulatorOdejmujacy();
                ko.Odejmij(a, b);
            }       

            if (operacja == Operacja.Mnozenie)
                return Mnozenie(a,b);

            if (operacja == Operacja.Dzielenie)
                return Dzielenie(a,b);

            throw new Exception("Nieznana operacja");
        }
        //szkolenia@tomaszles.pl
        //tomaszles.pl

        // http://pl.spoj.com/problems/JHTMLLET/

        // https://www.codewars.com/ 



        //private double Dodaj(int a, int b)
        //{
        //    return a + b;
        //}

        //private double Odejmij(int a, int b)
        //{
        //    return a - b;
        //}

        private double Mnozenie(int a, int b)
        {
            int wynik = a;
            for (int i = 0; i < b; i++)
                a += a;
            
            return a;
        }
        private double Dzielenie(int a, int b)
        {
            return a / b;
        }
    }
}
