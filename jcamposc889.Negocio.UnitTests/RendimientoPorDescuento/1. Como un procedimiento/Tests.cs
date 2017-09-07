using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.RendimientoPorDescuento.ComoUnProcedimiento;

namespace jcamposc889.Negocio.RendimientoPorDescuento.UnitTests.ComoUnProcedimiento
{
    [TestClass]
    public class CalculeElRendimientoPorDescuento_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;

        [TestMethod]
        public void CalculeElRendimientoPorDescuento_TieneTratamientoFiscal_RedondeoHaciaAbajo()
        {
            elResultadoEsperado = 21621.6216;
            elResultadoObtenido = Calculos.CalculeElRendimientoPorDescuento(320000, 
                300000, 0.08, new DateTime(2016, 10, 10), new DateTime(2016, 3, 3), true);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }

        [TestMethod]
        public void CalculeElRendimientoPorDescuento_TieneTratamientoFiscal_RedondeoHaciaArriba()
        {
            elResultadoEsperado = 22159.3592;
            elResultadoObtenido = Calculos.CalculeElRendimientoPorDescuento(320500,
                300000, 0.08, new DateTime(2016, 10, 10), new DateTime(2016, 3, 3), true);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }

        [TestMethod]
        public void CalculeElRendimientoPorDescuento_SinTratamientoFiscal_SinRedondeo()
        {
            elResultadoEsperado = 19999.9999;
            elResultadoObtenido = Calculos.CalculeElRendimientoPorDescuento(320000,
                300000.0001, 0.08, new DateTime(2016, 10, 10), new DateTime(2016, 3, 3), 
                false);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
