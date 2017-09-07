using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.IbanNacional.ConObjetos;

namespace jcamposc889.Negocio.IbanNacional.UnitTests.ConObjetos
{
    [TestClass]
    public class ComoNumero_Tests_Requerimiento
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;

        [TestMethod]
        public void ComoNumero_UnaCuentaCliente_ElRequerimientoComoEntero()
        {
            elResultadoEsperado = 10200009007408120122700M;
            elResultadoObtenido = new Requerimiento("10200009007408120").ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
