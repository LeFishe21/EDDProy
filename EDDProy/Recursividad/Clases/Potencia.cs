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
            if (pot == 0) // Todo número con potencia 0 (zero) es 1
            {
                return 1;
            }
            else
            {
                return bas * Pot(bas, pot - 1); // Realiza la formula a^b=a*a^b-1
            }
        }
    }
}
