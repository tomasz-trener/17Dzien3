using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P09Enumeratory
{
    enum Jednostka
    {
        Celcjusz,
        Kelvin,
        Farenheit
    }


    internal class ManagerPogody
    {
       // public string PolePubliczne;

        private const string znakKoncowy = ">";
        private const string adres = "https://www.google.com/search?q=pogoda";

        private Jednostka jednostka;
        private string szukanyZnak;

        /// <summary>
        /// Tworzenie narzędzia do pobierania temepertury dla zadanego miasta z seriwsu google.
        /// </summary>
        /// <param name="jednostka">Podaj jednostkę jako c lub f lub k</param>
        /// <param name="szukanyZnak">podaj znak celcjeusza gy korzystasz z seriwsu google</param>
        public ManagerPogody(Jednostka jednostka, string szukanyZnak)
        {
            this.jednostka = jednostka;
            this.szukanyZnak = szukanyZnak;
        }


        public Jednostka Jednostka
        {
            get
            {
                return jednostka;
            }
            set
            {
                jednostka = value;
            }
        }
        //  public string Jednostka { get; set; }
      
        // public string SzukanyZnak  { get; set; }

        private double TransformujTemeprature(double temp)
        {
            if (jednostka == Jednostka.Celcjusz)
                return temp;

            if(jednostka == Jednostka.Farenheit)
                return (temp *1.8)+32;


            if (jednostka == Jednostka.Kelvin)
                return temp + 273.15;

            throw new Exception("Nieznana jednostka");
        }

        /// <summary>
        /// Zwraca temerature dla podnaego miasta 
        /// </summary>
        /// <param name="miasto">podaj nazwe miasta</param>
        /// <returns>zwraca temeprature w ustawionej wcześniej jednostce</returns>
        public double PodajTemperature(string miasto)
        {
           // adres = "www.yahoo.com";

            WebClient wc = new WebClient();
            string dane = wc.DownloadString(adres + "+" + miasto);

            int indx = dane.IndexOf(szukanyZnak);
            int aktuanaPozycja = indx;

            while (dane.Substring(aktuanaPozycja, 1) != znakKoncowy)
                aktuanaPozycja--;

            string wynik = dane.Substring(aktuanaPozycja + 1, indx - aktuanaPozycja + 1);

            double wynikInt = Convert.ToInt32(wynik.Substring(0,wynik.Length-2));

            return TransformujTemeprature(wynikInt);
        }
    }
}
