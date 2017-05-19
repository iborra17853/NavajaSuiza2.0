using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavajaSuiza.Aplicación_3.ClaseLogica
{
    public class Apl3Lógica
    {
        /// <summary>
        /// hará el calculo entre una base y un exponente
        /// </summary>
        /// <param name="basee">valor que daremos como base </param>
        /// <param name="exponente">valor que daremos como exponente</param>
        /// <returns>el resultado de la operacion</returns>
        public static string BaseExponente(int basee, int exponente)
        {
            int resultado, i;
            string mensaje = " ";
            resultado = 1;
            i = 1;
            if (basee > 0)

                for (i = 1; i <= exponente; i++)
                {

                    resultado = resultado * basee;
                    mensaje = "El resultado será " + resultado;

                }


            else
            {
                mensaje = "Introduzca un numero valido";
            }
            return mensaje;
        }
    }
}

    

