using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.EstructuraDeDatos.ConObjetos;

namespace jcamposc889.Negocio.UnitTests.EstructuraDeDatos.ConObjetos.CodigoDeReferencia
{
    [TestClass]
    public class ComoTexto_Tests
    {
        private string elNumeroConsecutivo;
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private DateTime laFecha;

        [TestMethod]
        public void ComoTexto_FechaYConsecutivo_CodigoDeReferenciaCorrecto()
        {
            elResultadoEsperado = "20160303022058888888888887";

            laFecha = new DateTime(2016, 3, 3);
            elNumeroConsecutivo = "888888888888";

            elResultadoObtenido = new CodigoDeReferenciaParaInversion(laFecha, elNumeroConsecutivo).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
