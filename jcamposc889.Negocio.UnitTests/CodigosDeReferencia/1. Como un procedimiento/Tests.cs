using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.CodigosDeReferencia.ComoUnProcedimiento;

namespace jcamposc889.Negocio.CodigosDeReferencia.UnitTests.ComoUnProcedimiento
{
    [TestClass]
    public class GenereElCodigoDeReferencia_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void GenereElCodigoDeReferencia_GeneraDosVerificadores_TruncaUnDigito()
        {
            elResultadoEsperado = "20001111333228888888888881";

            elResultadoObtenido = CalculosDeCodigosDeReferencia.GenereElCodigoDeReferencia(new DateTime(2000, 11, 11), "333", "22", "888888888888");

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereElCodigoDeReferencia_ClienteTieneMenosDigitos_PrecedeConCero()
        {
            elResultadoEsperado = "20001111033228888888888885";

            elResultadoObtenido = CalculosDeCodigosDeReferencia.GenereElCodigoDeReferencia(new DateTime(2000, 11, 11), "33", "22", "888888888888");

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereElCodigoDeReferencia_SistemaTieneUnSoloDigito_PrecedeConCero()
        {
            elResultadoEsperado = "20001111333028888888888884";

            elResultadoObtenido = CalculosDeCodigosDeReferencia.GenereElCodigoDeReferencia(new DateTime(2000, 11, 11), "333", "2", "888888888888");

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereElCodigoDeReferencia_MesTieneUnSoloDigito_PrecedeConCero()
        {
            elResultadoEsperado = "20000111333228888888888885";

            elResultadoObtenido = CalculosDeCodigosDeReferencia.GenereElCodigoDeReferencia(new DateTime(2000, 1, 11), "333", "22", "888888888888");

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereElCodigoDeReferencia_DiaTieneUnSoloDigito_PrecedeConCero()
        {
            elResultadoEsperado = "20001101333228888888888883";

            elResultadoObtenido = CalculosDeCodigosDeReferencia.GenereElCodigoDeReferencia(new DateTime(2000, 11, 1), "333", "22", "888888888888");

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereElCodigoDeReferencia_elConsecutivoTieneMenosDigitos_PrecedeConCeros()
        {
            elResultadoEsperado = "20001111333220000000000047";

            elResultadoObtenido = CalculosDeCodigosDeReferencia.GenereElCodigoDeReferencia(new DateTime(2000, 11, 11), "333", "22", "4");

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
