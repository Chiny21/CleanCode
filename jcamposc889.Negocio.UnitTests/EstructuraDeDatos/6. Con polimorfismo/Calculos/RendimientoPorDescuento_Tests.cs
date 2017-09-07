using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo;

namespace jcamposc889.Negocio.UnitTests.EstructuraDeDatos.ConPolimorfismo
{
    [TestClass]
    public class RendimientoPorDescuento_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private Inversion laInversion;
        private DatosParaLaInversionConTratamiento losDatosCon;
        private DatosParaLaInversionSinTratamiento losDatosSin;

        [TestMethod]
        public void GenereUnaNuevaInversion_ConTratamientoFiscal_RendimientoPorDescuento()
        {
            elResultadoEsperado = 21621.6216;

            losDatosCon = new DatosParaLaInversionConTratamiento();
            losDatosCon.ValorFacial = 320000;
            losDatosCon.ValorTransadoNeto = 300000;
            losDatosCon.TasaDeImpuesto = 0.08;
            losDatosCon.FechaActual = new DateTime(2016, 3, 3);
            losDatosCon.FechaDeVencimiento = new DateTime(2016, 10, 10);
            losDatosCon.tieneTratamientoFiscal = true;
            losDatosCon.ConsecutivoParaElCodigoDeReferencia = "888888888888";
            laInversion = new Inversion(losDatosCon);

            elResultadoObtenido = laInversion.RendimientoPorDescuento;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }

        [TestMethod]
        public void GenereUnaNuevaInversion_SinTratamientoFiscal_RendimientoPorDescuento()
        {
            elResultadoEsperado = 20000;

            losDatosSin = new DatosParaLaInversionSinTratamiento();
            losDatosSin.ValorFacial = 320000;
            losDatosSin.ValorTransadoNeto = 300000;
            losDatosSin.TasaDeImpuesto = 0.08;
            losDatosSin.FechaActual = new DateTime(2016, 3, 3);
            losDatosSin.FechaDeVencimiento = new DateTime(2016, 10, 10);
            losDatosSin.tieneTratamientoFiscal = false;
            losDatosSin.ConsecutivoParaElCodigoDeReferencia = "888888888888";
            laInversion = new Inversion(losDatosSin);

            elResultadoObtenido = laInversion.RendimientoPorDescuento;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
