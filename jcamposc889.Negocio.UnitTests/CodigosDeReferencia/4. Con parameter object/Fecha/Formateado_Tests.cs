using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.CodigosDeReferencia.ConParameterObject;

namespace jcamposc889.Negocio.CodigosDeReferencia.UnitTests.ConParameterObject
{
    [TestClass]
    public class Fecha_ComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private DatosParaElRequerimiento losDatos;

        [TestMethod]
        public void ComoTexto_FechaCompleta_FechaComoTextoYConCerosNecesarios()
        {
            elResultadoEsperado = "20001111";

            losDatos = new DatosParaElRequerimiento();
            losDatos.Fecha = new DateTime(2000, 11, 11);
            elResultadoObtenido = new Fecha(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
