using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo;

namespace jcamposc889.Negocio.Impuesto.UnitTests.ConPolimorfismo
{
    [TestClass]
    public class CalculeElImpuesto_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private DatosDeInversionConTratamientoFiscal losDatosConTratamientoFiscal;
        private DatosDeInversionSinTratamientoFiscal losDatosSinTratamientoFiscal;

        [TestMethod]
        public void CalculeElImpuesto_TieneTratamientoFiscal_RedondeoHaciaAbajo()
        {
            elResultadoEsperado = 1621.6216;

            losDatosConTratamientoFiscal = new DatosDeInversionConTratamientoFiscal();
            losDatosConTratamientoFiscal.ValorFacial = 320000;
            losDatosConTratamientoFiscal.ValorTransadoNeto = 300000;
            losDatosConTratamientoFiscal.TasaDeImpuesto = 0.08;
            losDatosConTratamientoFiscal.FechaActual = new DateTime(2016, 10, 10);
            losDatosConTratamientoFiscal.FechaDeVencimiento = new DateTime(2016, 3, 3);
            losDatosConTratamientoFiscal.tieneTratamientoFiscal = true;

            elResultadoObtenido = losDatosConTratamientoFiscal.Impuesto;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void CalculeElImpuesto_TieneTratamientoFiscal_RedondeoHaciaArriba()
         {
            elResultadoEsperado = 1659.3592;

            losDatosConTratamientoFiscal = new DatosDeInversionConTratamientoFiscal();
            losDatosConTratamientoFiscal.ValorFacial = 320500;
            losDatosConTratamientoFiscal.ValorTransadoNeto = 300000;
            losDatosConTratamientoFiscal.TasaDeImpuesto = 0.08;
            losDatosConTratamientoFiscal.FechaActual = new DateTime(2016, 10, 10);
            losDatosConTratamientoFiscal.FechaDeVencimiento = new DateTime(2016, 3, 3);
            losDatosConTratamientoFiscal.tieneTratamientoFiscal = true;

            elResultadoObtenido = losDatosConTratamientoFiscal.Impuesto;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void CalculeElImpuesto_SinTratamientoFiscal_EsCero()
        {
            elResultadoEsperado = 0;

            losDatosSinTratamientoFiscal = new DatosDeInversionSinTratamientoFiscal();
            losDatosSinTratamientoFiscal.ValorFacial = 320000;
            losDatosSinTratamientoFiscal.ValorTransadoNeto = 300000.0001;
            losDatosSinTratamientoFiscal.TasaDeImpuesto = 0.08;
            losDatosSinTratamientoFiscal.FechaActual = new DateTime(2016, 10, 10);
            losDatosSinTratamientoFiscal.FechaDeVencimiento = new DateTime(2016, 3, 3);
            losDatosSinTratamientoFiscal.tieneTratamientoFiscal = false;

            elResultadoObtenido = losDatosSinTratamientoFiscal.Impuesto;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
