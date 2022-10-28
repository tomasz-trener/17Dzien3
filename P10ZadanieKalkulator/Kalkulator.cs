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
                return a + b;
            if (operacja == Operacja.Odejmowanie)
                return a - b;
            if (operacja == Operacja.Mnozenie)
                return a * b;
            if (operacja == Operacja.Dzielenie)
                return a / b;

            throw new Exception("Nieznana operacja");
        }
    }
}
