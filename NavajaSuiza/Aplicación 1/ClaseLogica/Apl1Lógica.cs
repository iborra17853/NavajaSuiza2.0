using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavajaSuiza.Aplicación_1.ClaseLogica
{
    class Apl1Lógica
    {
        /// <summary>
        /// identifica si el numero que se ignresara es primo o no
        /// </summary>
        /// <remarks>----</remarks>
        /// <param name="numero">Numero que se ingresa</param>
        /// <returns> si es primo o no</returns>
        public static string EsONoPrimo(int numero)
        {
            int contador, i;
            contador = 0;
            i = 1;
            string mensaje;
            while (i <= numero)
            {
                if (numero % i == 0)
                {
                    contador = contador + 1;
                }
                i = i + 1;
            }
            if (contador > 2)
            {
                mensaje = "No es primo";
            }
            else
            {
                mensaje = "Si es primo";
            }
            return mensaje;
        }
    }
}

