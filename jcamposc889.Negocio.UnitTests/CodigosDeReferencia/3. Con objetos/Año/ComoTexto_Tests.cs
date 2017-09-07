using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.CodigosDeReferencia.ConObjetos;

namespace jcamposc889.Negocio.CodigosDeReferencia.UnitTests.ConObjetos
{
    [TestClass]
    public class Año_ComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void ComoTexto_FechaCompleta_AñoComoTexto()
        {
            elResultadoEsperado = "2000";

            elResultadoObtenido = new Año(new DateTime(2000, 11, 11)).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
