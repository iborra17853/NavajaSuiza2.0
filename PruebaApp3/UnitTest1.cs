using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaApp3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void base2exponente2()
        {
            string cadenaesperada = "El resultado será 4";
            int basee = 2;
            int exponente = 2;
            string cadenaobtenida = NavajaSuiza.Aplicación_3.ClaseLogica.Apl3Lógica.BaseExponente(basee, exponente);
            Assert.AreEqual(cadenaobtenida, cadenaesperada);
        }
        [TestMethod]
        public void base2exponente0()
        {
            string cadenaesperada = "El resultado será 1";
            int basee = 2;
            int exponente = 0;
            string cadenaobtenida = NavajaSuiza.Aplicación_3.ClaseLogica.Apl3Lógica.BaseExponente(basee, exponente);
            Assert.AreEqual(cadenaobtenida, cadenaesperada);
        }
        [TestMethod]
        public void base0exponente0()
        {
            string cadenaesperada = "El resultado será 1";
            int basee = 0;
            int exponente = 0;
            string cadenaobtenida = NavajaSuiza.Aplicación_3.ClaseLogica.Apl3Lógica.BaseExponente(basee, exponente);
            Assert.AreEqual(cadenaobtenida, cadenaesperada);
        }

        [TestMethod]
        public void negativos()
        {
            string cadenaesperada = "Introduzca un numero valido";

            int basee = -2;
            int exponente = -2;
            string cadenaobtenida = NavajaSuiza.Aplicación_3.ClaseLogica.Apl3Lógica.BaseExponente(basee, exponente);
            Assert.AreEqual(cadenaobtenida, cadenaesperada);
        }

    }
}

