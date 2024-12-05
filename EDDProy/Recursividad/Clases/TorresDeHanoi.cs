using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recursividad.Clases
{
    internal class TorresDeHanoi
    {
        public void MoverDiscos(int n, char origen, char destino, char auxiliar, StringBuilder resultado)
        {
            if (n == 1)
            {
                resultado.AppendLine($" Mover disco 1 de {origen} a {destino},");
                return;
            }

            // Mover n-1 discos de la torre de origen a la torre auxiliar
            MoverDiscos(n - 1, origen, auxiliar, destino, resultado);

            // Mover el disco restante de la torre de origen a la torre de destino
            resultado.AppendLine($" Mover disco {n} de {origen} a {destino},");

            // Mover los n-1 discos de la torre auxiliar a la torre de destino
            MoverDiscos(n - 1, auxiliar, destino, origen, resultado);
        }
    }
}
