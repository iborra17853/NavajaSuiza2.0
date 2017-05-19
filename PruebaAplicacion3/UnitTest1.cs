using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaAplicacion3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NumeroPrimo1()
        {
            int numero = 1;

            bool esPrimoObtenido = NavajaSuiza.Aplicación_3.ClaseLogica.Apl3Lógica.EsPrimo(numero);

            Assert.IsTrue(esPrimoObtenido);
        }
     
        }
    }
    
}
}
