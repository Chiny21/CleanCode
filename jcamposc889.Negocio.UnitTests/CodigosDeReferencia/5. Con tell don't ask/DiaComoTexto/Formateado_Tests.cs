using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.CodigosDeReferencia.ConTellDontAsk;

namespace jcamposc889.Negocio.CodigosDeReferencia.UnitTests.ConTellDontAsk
{
    [TestClass]
    public class DiaComoTexto_Formateado_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private DatosParaElRequerimiento losDatos;

        [TestMethod]
        public void Formateado_FechaCompleta_DiaConLosCerosNecesarios()
        {
            elResultadoEsperado = "01";

            losDatos = new DatosParaElRequerimiento();
            losDatos.Fecha = new DateTime(2000, 11, 1);
            elResultadoObtenido = new DiaComoTexto(losDatos).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
