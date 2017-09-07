using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.IbanNacional.ConFunciones;

namespace jcamposc889.Negocio.IbanNacional.UnitTests.ConFunciones
{
    [TestClass]
    public class GenereElNumeroDeCuentaIban_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void GenereElNumeroDeCuentaIban_NumeroVerificadorEsDiez_NoSePrecedeConCero()
        {
            elResultadoEsperado = "CR1010200009007408120";

            elResultadoObtenido = CalculosDeCuentasIban.GenereElNumeroDeCuentaIban("10200009007408120");

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereElNumeroDeCuentaIban_NumeroVerificadorEsMenorADiez_SePrecedeConCero()
        {
            elResultadoEsperado = "CR0910000073919007800";

            elResultadoObtenido = CalculosDeCuentasIban.GenereElNumeroDeCuentaIban("10000073919007800");

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
