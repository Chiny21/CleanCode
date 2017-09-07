using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.CodigosDeReferencia.ConParameterObject;

namespace jcamposc889.Negocio.CodigosDeReferencia.UnitTests.ConParameterObject
{
    [TestClass]
    public class CodigoDeReferencia_ComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private DatosParaElRequerimiento losDatos;

        [TestMethod]
        public void ComoTexto_GeneraDosVerificadores_TruncaUnDigito()
        {
            elResultadoEsperado = "20001111333228888888888881";

            losDatos = new DatosParaElRequerimiento();
            losDatos.Fecha = new DateTime(2000, 11, 11);
            losDatos.NumeroDelCliente = "333";
            losDatos.NumeroDelSistema = "22";
            losDatos.NumeroConsecutivo = "888888888888";

            elResultadoObtenido = new CodigoDeReferencia(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoTexto_ClienteTieneMenosDigitos_PrecedeConCero()
        {
            elResultadoEsperado = "20001111033228888888888885";

            losDatos = new DatosParaElRequerimiento();
            losDatos.Fecha = new DateTime(2000, 11, 11);
            losDatos.NumeroDelCliente = "33";
            losDatos.NumeroDelSistema = "22";
            losDatos.NumeroConsecutivo = "888888888888";

            elResultadoObtenido = new CodigoDeReferencia(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoTexto_SistemaTieneUnSoloDigito_PrecedeConCero()
        {
            elResultadoEsperado = "20001111333028888888888884";

            losDatos = new DatosParaElRequerimiento();
            losDatos.Fecha = new DateTime(2000, 11, 11);
            losDatos.NumeroDelCliente = "333";
            losDatos.NumeroDelSistema = "2";
            losDatos.NumeroConsecutivo = "888888888888";

            elResultadoObtenido = new CodigoDeReferencia(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoTexto_MesTieneUnSoloDigito_PrecedeConCero()
        {
            elResultadoEsperado = "20000111333228888888888885";

            losDatos = new DatosParaElRequerimiento();
            losDatos.Fecha = new DateTime(2000, 1, 11);
            losDatos.NumeroDelCliente = "333";
            losDatos.NumeroDelSistema = "22";
            losDatos.NumeroConsecutivo = "888888888888";

            elResultadoObtenido = new CodigoDeReferencia(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoTexto_DiaTieneUnSoloDigito_PrecedeConCero()
        {
            elResultadoEsperado = "20001101333228888888888883";

            losDatos = new DatosParaElRequerimiento();
            losDatos.Fecha = new DateTime(2000, 11, 1);
            losDatos.NumeroDelCliente = "333";
            losDatos.NumeroDelSistema = "22";
            losDatos.NumeroConsecutivo = "888888888888";

            elResultadoObtenido = new CodigoDeReferencia(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoTexto_elConsecutivoTieneMenosDigitos_PrecedeConCeros()
        {
            elResultadoEsperado = "20001111333220000000000047";

            losDatos = new DatosParaElRequerimiento();
            losDatos.Fecha = new DateTime(2000, 11, 11);
            losDatos.NumeroDelCliente = "333";
            losDatos.NumeroDelSistema = "22";
            losDatos.NumeroConsecutivo = "4";

            elResultadoObtenido = new CodigoDeReferencia(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
