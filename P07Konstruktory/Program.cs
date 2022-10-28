using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07Konstruktory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kalkulator k = new Kalkulator("normalny");

            k.Policz(3, 5);

        }
    }
}
