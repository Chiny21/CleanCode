using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.CodigosDeReferencia.ConParameterObject;

namespace jcamposc889.Negocio.CodigosDeReferencia.UnitTests.ConParameterObject
{
    [TestClass]
    public class Requerimietno_ComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private DatosParaElRequerimiento losDatos;

        [TestMethod]
        public void ComoTexto_FechaNumeroDelClienteSistemaYConsecutivo_RequerimientoComoTexto()
        {
            elResultadoEsperado = "2000111133322888888888888";

            losDatos = new DatosParaElRequerimiento();
            losDatos.Fecha = new DateTime(2000,11,11);
            losDatos.NumeroDelCliente = "333";
            losDatos.NumeroDelSistema = "22";
            losDatos.NumeroConsecutivo = "888888888888";

            elResultadoObtenido = new Requerimiento(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
