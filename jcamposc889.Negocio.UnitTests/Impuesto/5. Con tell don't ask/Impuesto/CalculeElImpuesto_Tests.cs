using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.RendimientoPorDescuento.ConTellDontAsk;

namespace jcamposc889.Negocio.Impuesto.UnitTests.ConTellDontAsk
{
    [TestClass]
    public class CalculeElImpuesto_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private DatosParaElRendimientoPorDescuento losDatos;

        [TestMethod]
        public void CalculeElImpuesto_TieneTratamientoFiscal_RedondeoHaciaAbajo()
        {
            elResultadoEsperado = 1621.6216;

            losDatos = new DatosParaElRendimientoPorDescuento();
            losDatos.ValorFacial = 320000;
            losDatos.ValorTransadoNeto = 300000;
            losDatos.TasaDeImpuesto = 0.08;
            losDatos.FechaActual = new DateTime(2016, 10, 10);
            losDatos.FechaDeVencimiento = new DateTime(2016, 3, 3);
            losDatos.tieneTratamientoFiscal = true;

            elResultadoObtenido = losDatos.Impuesto;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void CalculeElImpuesto_TieneTratamientoFiscal_RedondeoHaciaArriba()
        {
            elResultadoEsperado = 1659.3592;

            losDatos = new DatosParaElRendimientoPorDescuento();
            losDatos.ValorFacial = 320500;
            losDatos.ValorTransadoNeto = 300000;
            losDatos.TasaDeImpuesto = 0.08;
            losDatos.FechaActual = new DateTime(2016, 10, 10);
            losDatos.FechaDeVencimiento = new DateTime(2016, 3, 3);
            losDatos.tieneTratamientoFiscal = true;

            elResultadoObtenido = losDatos.Impuesto;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void CalculeElImpuesto_SinTratamientoFiscal_EsCero()
        {
            elResultadoEsperado = 0;

            losDatos = new DatosParaElRendimientoPorDescuento();
            losDatos.ValorFacial = 320000;
            losDatos.ValorTransadoNeto = 300000.0001;
            losDatos.TasaDeImpuesto = 0.08;
            losDatos.FechaActual = new DateTime(2016, 10, 10);
            losDatos.FechaDeVencimiento = new DateTime(2016, 3, 3);
            losDatos.tieneTratamientoFiscal = false;

            elResultadoObtenido = losDatos.Impuesto;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
