using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFisBas
{
    class FisBas
    {
        public FisBas() //konstruktor
        {

        }

        public static string  GetNumber()
        {
             string mesText ="";

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine(" Wpisany tekst nie jest liczbą całkowitą, wpisz liczbę całkowitą.");
                    continue;
                }
                else
                {
                    if ((number % 3 == 0) && (number % 5 == 0))
                    {
                        mesText = "FisBas";
                        //return mesText;
                    }
                    else if (!(number % 3 == 0) && !(number % 5 == 0))
                    {
                        mesText = number.ToString();
                        //return mesText;
                    }
                    else if (number % 3 == 0)
                    {
                        mesText = "Fis";
                        //return mesText;
                    }
                    else if( number % 5 == 0)
                    {
                        mesText = "Bas";
                        //return mesText;
                    }

                    return mesText;
                }
            }
        }
    }
}
