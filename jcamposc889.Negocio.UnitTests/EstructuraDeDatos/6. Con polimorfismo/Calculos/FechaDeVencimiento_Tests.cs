using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo;

namespace jcamposc889.Negocio.UnitTests.EstructuraDeDatos.ConPolimorfismo
{
    [TestClass]
    public class FechaDeVencimiento_Tests
    {
        private DateTime elResultadoEsperado;
        private DateTime elResultadoObtenido;
        private Inversion laInversion;
        private DatosParaLaInversionConTratamiento losDatos;

        [TestMethod]
        public void GenereUnaNuevaInversion_FechaDeVencimiento()
        {
            elResultadoEsperado = new DateTime(2016, 10, 10);

            losDatos = new DatosParaLaInversionConTratamiento();
            losDatos.ValorFacial = 320000;
            losDatos.ValorTransadoNeto = 300000;
            losDatos.TasaDeImpuesto = 0.08;
            losDatos.FechaActual = new DateTime(2016, 3, 3);
            losDatos.FechaDeVencimiento = new DateTime(2016, 10, 10);
            losDatos.ConsecutivoParaElCodigoDeReferencia = "888888888888";
            laInversion = new Inversion(losDatos);

            elResultadoObtenido = laInversion.FechaDeVencimiento;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
