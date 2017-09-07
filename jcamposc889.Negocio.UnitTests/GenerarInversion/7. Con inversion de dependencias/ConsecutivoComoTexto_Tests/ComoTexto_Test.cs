using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inversiones.Negocio.GenerarInversion.ConInversionDeDependencias;
using NSubstitute;

namespace jcamposc889.Negocio.UnitTests.GenerarInversion.ConInversionDeDependencias.ConsecutivoComoTexto_Tests
{
    [TestClass]
    public class ComoTexto_Test
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private DatosParaLaFecha losDatos;

        [TestMethod]
        public void ComoTexto_DatosParaLaFecha_ConsecutivoComoTexto()
        {
            elResultadoEsperado = "888888888";

            losDatos = Substitute.For<DatosParaLaFecha>();
            losDatos.Consecutivo.Returns(888888888);

            elResultadoObtenido = new ConsecutivoComoTexto(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
