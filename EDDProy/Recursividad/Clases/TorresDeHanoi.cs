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

            MoverDiscos(n - 1, origen, auxiliar, destino, resultado); // mover los discos a la torre auxiliar

            resultado.AppendLine($" Mover disco {n} de {origen} a {destino},"); // Mover los discos restantes al destino

            MoverDiscos(n - 1, auxiliar, destino, origen, resultado); // Mover los discors de la auxiliar al destino
        }
    }
}
