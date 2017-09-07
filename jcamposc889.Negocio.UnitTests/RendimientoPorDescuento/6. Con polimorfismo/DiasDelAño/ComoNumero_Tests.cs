using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo;

namespace jcamposc889.Negocio.RendimientoPorDescuento.UnitTests.ConPolimorfismo
{
    [TestClass]
    public class DiasDelAño_ComoNumero_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private DatosDeInversion losDatos;

        [TestMethod]
        public void ComoNumero_AñoNormal_365Dias()
        {
            elResultadoEsperado = 365;

            losDatos = new DatosDeInversionConTratamientoFiscal();
            losDatos.FechaActual = new DateTime(2015, 10, 10);

            elResultadoObtenido = new DiasDelAño(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_AñoBisiesto_366Dias()
        {
            elResultadoEsperado = 366;

            losDatos = new DatosDeInversionConTratamientoFiscal();
            losDatos.FechaActual = new DateTime(2016, 10, 10);

            elResultadoObtenido = new DiasDelAño(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
