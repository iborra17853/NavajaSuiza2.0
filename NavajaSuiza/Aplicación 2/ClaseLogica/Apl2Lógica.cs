using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavajaSuiza.Aplicación_2.ClaseLogica
{           
    
    class Apl2Lógica
    {
        /// <summary>
        /// Nos devolverá la funcion de que el numero elegido aparecerá tantas veces como se indique entre un valor de 1 y 15 
        /// </summary>
        /// <param name="numero">numero que se introduce </param>
        /// <returns>el resultado final</returns>
        public static string contar15(int numero)
        {
            int i, j;
            string resultado = " ";
            string mensaje = " ";



            if (numero >= 1 && numero <= 15)
            {

                for (i = 1; i <= numero; i++)
                {
                    for (j = 1; j <= 15; j++)
                    {
                        resultado = resultado + j + ",";
                    }
                    resultado = resultado + "\n";
                }
                mensaje = (resultado);
            }
            else
            {
                mensaje = ("Numero no válido");
            }
            return mensaje;
        }
    }
}
