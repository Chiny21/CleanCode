using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.IbanNacional.ConObjetos;

namespace jcamposc889.Negocio.IbanNacional.UnitTests.ConObjetos
{
    [TestClass]
    public class ComoNumero_Tests_NumeroVerificador
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;

        [TestMethod]
        public void ComoNumero_UnaCuentaCliente_ElNumeroVerificador()
        {
            elResultadoEsperado = 10;
            elResultadoObtenido = new NumeroVerificador("10200009007408120").ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
