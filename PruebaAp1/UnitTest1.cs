using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaAp1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NumPrimo1()
        {
            int numero = 2;

            string esPrimoObtenido = NavajaSuiza.Aplicación_1.Logica.LogicaApp1.
                EsPrimo(numero);

            Assert.IsTrue(esPrimoObtenido);
        }
    }
}
