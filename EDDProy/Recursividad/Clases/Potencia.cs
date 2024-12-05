using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recursividad.Clases
{
    internal class Potencia
    {
        public int Pot(int bas, int pot)
        {
            if (pot == 0)
            //cualquier numero a la potencia 0 es 1
            {
                return 1;
            }
            else
            //ejecuto la formula a^b=a*a^b-1
            {
                return bas * Pot(bas, pot - 1);
            }
        }
    }
}
