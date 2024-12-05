using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recursividad.Clases
{
    internal class Factorial
    {
        public long fact(int num)
        {
            if (num == 0 || num == 1)
                return 1;

            return num * fact(num - 1);
        }
    }
}
