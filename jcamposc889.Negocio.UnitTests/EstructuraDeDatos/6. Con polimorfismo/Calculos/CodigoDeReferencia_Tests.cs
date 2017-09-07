using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo;

namespace jcamposc889.Negocio.UnitTests.EstructuraDeDatos.ConPolimorfismo
{
    [TestClass]
    public class CodigoDeReferencia_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private Inversion laInversion;
        private DatosParaLaInversionConTratamiento losDatos;

        [TestMethod]
        public void GenereUnaNuevaInversion_CodigoDeReferencia()
        {
            elResultadoEsperado = "20160303022058888888888887";

            losDatos = new DatosParaLaInversionConTratamiento();
            losDatos.ValorFacial = 320000;
            losDatos.ValorTransadoNeto = 300000;
            losDatos.TasaDeImpuesto = 0.08;
            losDatos.FechaActual = new DateTime(2016, 3, 3);
            losDatos.FechaDeVencimiento = new DateTime(2016, 10, 10);
            losDatos.ConsecutivoParaElCodigoDeReferencia = "888888888888";
            laInversion = new Inversion(losDatos);

            elResultadoObtenido = laInversion.CodigoDeReferencia;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
