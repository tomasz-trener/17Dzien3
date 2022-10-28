using P50Wlasciwosci.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P50Wlasciwosci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj zdanie");
            string zdanie = Console.ReadLine();

            ManagerTekstu mt = new ManagerTekstu();
            mt.Zdanie = zdanie;
            try
            {
                string najdluzszy = mt.ZnajdzNajdluzszyWyraz();

                Console.WriteLine("Pierwszy najdluższy: " + najdluzszy);

                string[] wyrazy = mt.ZnajdzWszystkieNajdluzszeWyrazy();

                Console.WriteLine("Wszystkie najdłuższe: " + string.Join(", ", wyrazy));
            }
            catch (ToShortSentenseException)
            {
                Console.WriteLine("Zdanie za krótkie");
            }
            catch (Exception)
            {
                Console.WriteLine("Nieznany błąd");
            }


            Console.ReadKey();
        }
    }
}
