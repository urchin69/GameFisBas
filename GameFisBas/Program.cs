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
            Console.WriteLine(" Podaj liczbę całkowitą!");
            var number = FisBas.GetNumber();
            Console.WriteLine(number);
        }
    }
}
