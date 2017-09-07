using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo;

namespace jcamposc889.Negocio.UnitTests.EstructuraDeDatos.ConPolimorfismo.CodigoDeReferencia
{
    [TestClass]
    public class ComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private DatosParaLaInversionConTratamiento losDatos;

        [TestMethod]
        public void ComoTexto_FechaYConsecutivo_CodigoDeReferenciaCorrecto()
        {
            elResultadoEsperado = "20160303022058888888888887";

            losDatos = new DatosParaLaInversionConTratamiento();
            losDatos.FechaActual = new DateTime(2016, 3, 3);
            losDatos.ConsecutivoParaElCodigoDeReferencia = "888888888888";

            elResultadoObtenido = new CodigoDeReferenciaParaInversion(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
