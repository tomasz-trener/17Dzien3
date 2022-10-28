using P50Wlasciwosci.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P50Wlasciwosci
{
    internal class ManagerTekstu
    {
        public string Zdanie { get; set; }

        public string ZnajdzNajdluzszyWyraz()
        {
            if (Zdanie.Length < 1)
                throw new ToShortSentenseException();

            string[] wyrazy = Zdanie.Split(' ');

            string aktualnieNajdluzszy = "";
            foreach (var w in wyrazy)
                if (w.Length > aktualnieNajdluzszy.Length)
                    aktualnieNajdluzszy = w;

            return aktualnieNajdluzszy;
        }

        public string[] ZnajdzWszystkieNajdluzszeWyrazy()
        {
            if (Zdanie.Length < 1)
                throw new ToShortSentenseException();

            string najdluszy = ZnajdzNajdluzszyWyraz();
            return znajdzWyrazyOPodanejDlugosc(najdluszy.Length);
        }

        private string[] znajdzWyrazyOPodanejDlugosc(int dlugosc)
        {
            List<string> znalezione = new List<string>();
            string[] wyrazy = Zdanie.Split(' ');
            foreach (var w in wyrazy)
                if (w.Length == dlugosc)
                    znalezione.Add(w);

            return znalezione.ToArray();
        }



    }
}
