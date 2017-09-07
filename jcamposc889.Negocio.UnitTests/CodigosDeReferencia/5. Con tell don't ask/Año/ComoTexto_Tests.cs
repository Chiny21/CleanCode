using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.CodigosDeReferencia.ConTellDontAsk;

namespace jcamposc889.Negocio.CodigosDeReferencia.UnitTests.ConTellDontAsk
{
    [TestClass]
    public class Año_ComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private DatosParaElRequerimiento losDatos;

        [TestMethod]
        public void ComoTexto_FechaCompleta_AñoComoTexto()
        {
            elResultadoEsperado = "2000";

            losDatos = new DatosParaElRequerimiento();
            losDatos.Fecha = new DateTime(2000, 11, 11);
            elResultadoObtenido = new Año(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
