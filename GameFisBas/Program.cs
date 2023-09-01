using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFisBas
{
    class Program
    {
        static void Main(string[] args)
        {
            string _number;
            //int number;

            Console.WriteLine(" Podaj liczbę całkowitą!");
            _number = Console.ReadLine();

            while (true)
            {
                if (!int.TryParse(_number, out int number))
                {
                    Console.WriteLine(" Wpisany tekst nie jest liczbą całkowitą, wpisz liczbę całkowitą.");
                    _number = Console.ReadLine();
                    continue;
                }
                else
                Console.WriteLine(FisBas.GetNumber(number));
                break;

            }
        }
    }
}
