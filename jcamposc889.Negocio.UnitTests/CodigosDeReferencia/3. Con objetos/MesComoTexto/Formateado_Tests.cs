using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.CodigosDeReferencia.ConObjetos;

namespace jcamposc889.Negocio.CodigosDeReferencia.UnitTests.ConObjetos
{
    [TestClass]
    public class MesComoTexto_Formateado_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void Formateado_FechaCompleta_MesConLosCerosNecesarios()
        {
            elResultadoEsperado = "01";

            elResultadoObtenido = new MesComoTexto(new DateTime(2000, 1, 11)).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
