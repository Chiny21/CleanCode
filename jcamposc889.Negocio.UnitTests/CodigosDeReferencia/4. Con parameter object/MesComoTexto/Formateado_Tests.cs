using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.CodigosDeReferencia.ConParameterObject;

namespace jcamposc889.Negocio.CodigosDeReferencia.UnitTests.ConParameterObject
{
    [TestClass]
    public class MesComoTexto_Formateado_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private DatosParaElRequerimiento losDatos;

        [TestMethod]
        public void Formateado_FechaCompleta_MesConLosCerosNecesarios()
        {
            elResultadoEsperado = "01";

            losDatos = new DatosParaElRequerimiento();
            losDatos.Fecha = new DateTime(2000, 1, 11);
            elResultadoObtenido = new MesComoTexto(losDatos).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
