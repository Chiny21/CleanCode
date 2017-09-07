using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.CodigosDeReferencia.ConObjetos;

namespace jcamposc889.Negocio.CodigosDeReferencia.UnitTests.ConObjetos
{
    [TestClass]
    public class DigitoVerificador_ComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void ComoTexto_elRequerimiento_TruncaUnDigito()
        {
            elResultadoEsperado = "1";

            elResultadoObtenido = new DigitoVerificador("2000111133322888888888888").ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoTexto_elRequerimiento_ResiduoComoDigitoVerificador()
        {
            elResultadoEsperado = "5";

            elResultadoObtenido = new DigitoVerificador("2000111103322888888888888").ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
