using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieManagerTekstu
{
    internal class ManagerTekstu
    {
        public string ZnajdzNajdluzszyWyraz(string zdanie)
        {
            string[] wyrazy = zdanie.Split(' ');

            string aktualnieNajdluzszy = "";
            foreach (var w in wyrazy)
                if (w.Length > aktualnieNajdluzszy.Length)
                    aktualnieNajdluzszy = w;
            
            return aktualnieNajdluzszy;
        }

        public string[] ZnajdzWszystkieNajdluzszeWyrazy(string zdanie)
        {
            string najdluszy = ZnajdzNajdluzszyWyraz(zdanie);
            return znajdzWyrazyOPodanejDlugosc(najdluszy.Length, zdanie);
        }

        private string[] znajdzWyrazyOPodanejDlugosc(int dlugosc, string zdanie)
        {
            List<string> znalezione = new List<string>();
            string[] wyrazy = zdanie.Split(' ');
            foreach (var w in wyrazy)
                if (w.Length == dlugosc)
                    znalezione.Add(w);

            return znalezione.ToArray();
        }



    }
}
