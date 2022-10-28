using P03ObslugaBledow.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ObslugaBledow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulator k = new Kalkulator();

            while (true)
            {
                Console.WriteLine("podaj rówoanie");

                string rownanie = Console.ReadLine();
                try
                {
                    double wynik1 = k.WykonajDzialanie(rownanie);
                    Console.WriteLine(wynik1);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Zły format danych. Twoje równanie może sikładać się tylko z dwóch argumentów");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Nie możesz dzielić przez 0");
                }
                catch (BadOperatorException)
                {
                    Console.WriteLine("Podano zły operator");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wystąpił nieznany bład");

                    // mozemy wskorzystać z systemu do logowania błedów i przekazac ten błąd do logów
                    //Console.WriteLine(ex.Message);
                }
                finally
                {
                    // gdy chcemy upiewnić się, że np. połączenie z zew. źródłem zostanie zamknięte 
                }

            }
           


            //double wynik2 = k.WykonajDzialanie("100+3*100"); // bład formatException

            // double wynik3 = k.WykonajDzialanie("100/0"); // bład DivideByZeroException

            // double wynik4 = k.WykonajDzialanie("100^2"); // bład Exception

        }
    }
}
