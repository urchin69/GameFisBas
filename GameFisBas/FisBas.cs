using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFisBas
{
    class FisBas
    {
        public  static string  GetNumber(int _number)
        {
             string mesText ="";

            if (_number % 3 == 0 && _number % 5 == 0)
                mesText = "FisBas";
            else if (_number % 3 == 0)
                mesText = "Fis";
            else if (_number % 5 == 0)
                mesText = "Bas";
            else
                mesText = _number.ToString();

            return mesText;
        }
    }
}
