using System;
using NavajaSuiza;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaApp2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Cadena1()
        {
            string cadenaesperada = " 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,\n";
            int numero = 1;
            string cadenaobtenida = NavajaSuiza.Aplicación_2.ClaseLogica.Apl2Lógica.contar15(numero);
            Assert.AreEqual(cadenaobtenida, cadenaesperada);
        }
        [TestMethod]
        public void Valor0()
        {
            string cadenaesperada = "Numero no válido";
            int numero = 0;
            string cadenaobtenida = NavajaSuiza.Aplicación_2.ClaseLogica.Apl2Lógica.contar15(numero);
            Assert.AreEqual(cadenaobtenida, cadenaesperada);
        }
        [TestMethod]
        public void Cadena2()
        {
            string cadenaesperada = " 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,\n1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,\n";
            int numero = 2;
            string cadenaobtenida = NavajaSuiza.Aplicación_2.ClaseLogica.Apl2Lógica.contar15(numero);
            Assert.AreEqual(cadenaobtenida, cadenaesperada);
        }
        [TestMethod]
        public void CadenaNegativo()
        {
            string cadenaesperada = "Numero no válido";
            int numero = -1;
            string cadenaobtenida = NavajaSuiza.Aplicación_2.ClaseLogica.Apl2Lógica.contar15(numero);
            Assert.AreEqual(cadenaobtenida, cadenaesperada);
        }
    }
}

