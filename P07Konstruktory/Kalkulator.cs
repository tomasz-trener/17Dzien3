using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07Konstruktory
{
    internal class Kalkulator
    {
        private string typ;

        public Kalkulator(string typ)
        {
           this.typ = typ;
        }

        public double Policz(int a, int b)
        {
            if (this.typ=="normalny")
            {
                return a + b;
            }
            else if(typ=="naukowy")
            {
                return a + b;
            }

            throw new Exception("...");

            
        }
    }
}
