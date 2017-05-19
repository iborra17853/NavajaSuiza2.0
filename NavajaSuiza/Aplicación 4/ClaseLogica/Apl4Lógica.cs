using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavajaSuiza.Aplicación_4.ClaseLogica
{
    class Apl4Lógica
    {
        /// <summary>
        /// calculara todos los multiplos de 3 hasta 99 y nos hará la suma de todos después
        /// </summary>
        /// <returns>devolvera los multiplos de 3 hsata 99 y la suma de estos </returns>
        public static string multiplos3()
        {
            string mensaje = " ";
            int i, suma, contNum;
            string texto;

            i = 3;
            suma = 0;
            contNum = 0;
            texto = "";

            while (i <= 100)
            {
                if (contNum == 10)
                {
                    contNum = 0;
                    texto = texto + "\n";
                }
                if (i % 3 == 0)
                {
                    texto = texto + i + ", ";
                    suma = suma + i;
                    contNum++;
                }
                i = i + 1;
            }
            mensaje = "Los múltiplos de 3 son: " + "\n" + texto + "y la suma de todos es: " + suma;
            return mensaje;

        }
    }
}

