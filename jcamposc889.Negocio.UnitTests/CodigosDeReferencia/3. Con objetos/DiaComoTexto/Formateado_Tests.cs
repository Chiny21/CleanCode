using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.CodigosDeReferencia.ConObjetos;

namespace jcamposc889.Negocio.CodigosDeReferencia.UnitTests.ConObjetos
{
    [TestClass]
    public class DiaComoTexto_Formateado_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void Formateado_FechaCompleta_DiaConLosCerosNecesarios()
        {
            elResultadoEsperado = "01";

            elResultadoObtenido = new DiaComoTexto(new DateTime(2000, 11, 1)).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
