using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo;

namespace jcamposc889.Negocio.RendimientoPorDescuento.UnitTests.ConPolimorfismo
{
    [TestClass]
    public class CalculeElRendimientoPorDescuento_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private DatosDeInversionConTratamientoFiscal losDatosConTratamiento;
        private DatosDeInversionSinTratamientoFiscal losDatosSinTratamiento;
        private DatosDeInversion360 losDatos360;

        [TestMethod]
        public void CalculeElRendimientoPorDescuento_TieneTratamientoFiscal_RedondeoHaciaAbajo()
        {
            elResultadoEsperado = 21621.6216;

            losDatosConTratamiento = new DatosDeInversionConTratamientoFiscal();
            losDatosConTratamiento.ValorFacial = 320000;
            losDatosConTratamiento.ValorTransadoNeto = 300000;
            losDatosConTratamiento.TasaDeImpuesto = 0.08;
            losDatosConTratamiento.FechaActual = new DateTime(2016, 10, 10);
            losDatosConTratamiento.FechaDeVencimiento = new DateTime(2016, 3, 3);

            elResultadoObtenido = new RendimientosPorDescuento(losDatosConTratamiento).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }

        [TestMethod]
        public void CalculeElRendimientoPorDescuento_TieneTratamientoFiscal_RedondeoHaciaArriba()
        {
            elResultadoEsperado = 22159.3591;

            losDatosConTratamiento = new DatosDeInversionConTratamientoFiscal();
            losDatosConTratamiento.ValorFacial = 320500;
            losDatosConTratamiento.ValorTransadoNeto = 300000;
            losDatosConTratamiento.TasaDeImpuesto = 0.08;
            losDatosConTratamiento.FechaActual = new DateTime(2016, 10, 10);
            losDatosConTratamiento.FechaDeVencimiento = new DateTime(2016, 3, 3);

            elResultadoObtenido = new RendimientosPorDescuento(losDatosConTratamiento).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }

        [TestMethod]
        public void CalculeElRendimientoPorDescuento_SinTratamientoFiscal_SinRedondeo()
        {
            elResultadoEsperado = 19999.9999;

            losDatosSinTratamiento = new DatosDeInversionSinTratamientoFiscal();
            losDatosSinTratamiento.ValorFacial = 320000;
            losDatosSinTratamiento.ValorTransadoNeto = 300000.0001;
            losDatosSinTratamiento.TasaDeImpuesto = 0.08;
            losDatosSinTratamiento.FechaActual = new DateTime(2016, 10, 10);
            losDatosSinTratamiento.FechaDeVencimiento = new DateTime(2016, 3, 3);

            elResultadoObtenido = new RendimientosPorDescuento(losDatosSinTratamiento).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }

        [TestMethod]
        public void CalculeElRendimientoPorDescuento_Tratamiendo360_RedondeoHaciaArriba()
        {
            elResultadoEsperado = 21621.6216;

            losDatos360 = new DatosDeInversion360();
            losDatos360.ValorFacial = 320000;
            losDatos360.ValorTransadoNeto = 300000;
            losDatos360.TasaDeImpuesto = 0.08;
            losDatos360.FechaActual = new DateTime(2016, 10, 10);
            losDatos360.FechaDeVencimiento = new DateTime(2016, 3, 3);

            elResultadoObtenido = new RendimientosPorDescuento(losDatos360).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
