using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10ZadanieKalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulator k = new Kalkulator();

            double wynik=
                k.WykonajOperacje(4, 5, Operacja.Mnozenie);


            //string s = "ala%%ma&&Kota";

            //string[] separatory = { "%%", "&&" };
            //s.Split(separatory, StringSplitOptions.None);


        }
    }
}
