using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.CodigosDeReferencia.ConObjetos;

namespace jcamposc889.Negocio.CodigosDeReferencia.UnitTests.ConObjetos
{
    [TestClass]
    public class CodigoDeReferencia_ComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void ComoTexto_GeneraDosVerificadores_TruncaUnDigito()
        {
            elResultadoEsperado = "20001111333228888888888881";

            elResultadoObtenido = new CodigoDeReferencia(new DateTime(2000, 11, 11), "333", "22", "888888888888").ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoTexto_ClienteTieneMenosDigitos_PrecedeConCero()
        {
            elResultadoEsperado = "20001111033228888888888885";

            elResultadoObtenido = new CodigoDeReferencia(new DateTime(2000, 11, 11), "33", "22", "888888888888").ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoTexto_SistemaTieneUnSoloDigito_PrecedeConCero()
        {
            elResultadoEsperado = "20001111333028888888888884";

            elResultadoObtenido = new CodigoDeReferencia(new DateTime(2000, 11, 11), "333", "2", "888888888888").ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoTexto_MesTieneUnSoloDigito_PrecedeConCero()
        {
            elResultadoEsperado = "20000111333228888888888885";

            elResultadoObtenido = new CodigoDeReferencia(new DateTime(2000, 1, 11), "333", "22", "888888888888").ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoTexto_DiaTieneUnSoloDigito_PrecedeConCero()
        {
            elResultadoEsperado = "20001101333228888888888883";

            elResultadoObtenido = new CodigoDeReferencia(new DateTime(2000, 11, 1), "333", "22", "888888888888").ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoTexto_elConsecutivoTieneMenosDigitos_PrecedeConCeros()
        {
            elResultadoEsperado = "20001111333220000000000047";

            elResultadoObtenido = new CodigoDeReferencia(new DateTime(2000, 11, 11), "333", "22", "4").ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
