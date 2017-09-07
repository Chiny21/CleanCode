using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.IbanNacional.ConObjetos;

namespace jcamposc889.Negocio.IbanNacional.UnitTests.ConObjetos
{
    [TestClass]
    public class Formateados_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void Formateados_NumeroVerificadorEsDiez_NoSePrecedeConCero()
        {
            elResultadoEsperado = "10";

            elResultadoObtenido = new DigitosVerificadores("10200009007408120").Formateados();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void Formateados_NumeroVerificadorEsMenorADiez_SePrecedeConCero()
        {
            elResultadoEsperado = "09";

            elResultadoObtenido = new DigitosVerificadores("10000073919007800").Formateados();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
