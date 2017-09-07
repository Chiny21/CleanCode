using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.IbanNacional.ConObjetos;

namespace jcamposc889.Negocio.IbanNacional.UnitTests.ConObjetos
{
    [TestClass]
    public class ComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void ComoTexto_NumeroVerificadorEsDiez_NoSePrecedeConCero()
        {
            elResultadoEsperado = "CR1010200009007408120";

            elResultadoObtenido = new NumeroDeCuentaIBAN("10200009007408120").ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoTexto_NumeroVerificadorEsMenorADiez_SePrecedeConCero()
        {
            elResultadoEsperado = "CR0910000073919007800";

            elResultadoObtenido = new NumeroDeCuentaIBAN("10000073919007800").ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
