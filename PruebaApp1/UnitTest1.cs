using System;
using NavajaSuiza;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaApp1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NumeroEsPrimo3()
        {
            string cadenaesperada = "Si es primo";
            int numero = 3;
            string cadenaobtenida = NavajaSuiza.Aplicación_1.ClaseLogica.Apl1Lógica.EsONoPrimo(numero);
            Assert.AreEqual(cadenaobtenida,cadenaesperada);
        }
        [TestMethod]
        public void NumeroEsPrimo4()
        {
            string cadenaesperada = "No es primo";
            int numero = 4;
            string cadenaobtenida = NavajaSuiza.Aplicación_1.ClaseLogica.Apl1Lógica.EsONoPrimo(numero);
            Assert.AreEqual(cadenaobtenida, cadenaesperada);
        }
        [TestMethod]
        public void NumeroEsPrimo0()
        {
            string cadenaesperada = "Si es primo";
            int numero = 0;
            string cadenaobtenida = NavajaSuiza.Aplicación_1.ClaseLogica.Apl1Lógica.EsONoPrimo(numero);
            Assert.AreEqual(cadenaobtenida, cadenaesperada);
        }
        [TestMethod]
        public void NumeroEsPrimoMinValue()
        {
            string cadenaesperada = "Si es primo";
            int numero = int.MinValue;
            string cadenaobtenida = NavajaSuiza.Aplicación_1.ClaseLogica.Apl1Lógica.EsONoPrimo(numero);
            Assert.AreEqual(cadenaobtenida, cadenaesperada);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NumeroEsPrimoMaxValue()
        {
            string cadenaesperada = "Si es primo";
            int numero = int.MaxValue;
            string cadenaobtenida = NavajaSuiza.Aplicación_1.ClaseLogica.Apl1Lógica.EsONoPrimo(numero);
            Assert.AreEqual(cadenaobtenida, cadenaesperada);
        }
        [TestMethod]
        public void NumeroEsPrimoMaxValue2()
        {
            string cadenaesperada = "No es primo";
            int numero = int.MaxValue-1;
            string cadenaobtenida = NavajaSuiza.Aplicación_1.ClaseLogica.Apl1Lógica.EsONoPrimo(numero);
            Assert.AreEqual(cadenaobtenida, cadenaesperada);
        }
        [TestMethod]
        public void NumeroEsPrimoMinValue2()
        {
            string cadenaesperada = "No es primo";
            int numero = int.MaxValue-1;
            string cadenaobtenida = NavajaSuiza.Aplicación_1.ClaseLogica.Apl1Lógica.EsONoPrimo(numero);
            Assert.AreEqual(cadenaobtenida, cadenaesperada);
        }
    }
}