using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo;

namespace jcamposc889.Negocio.RendimientoPorDescuento.UnitTests.ConPolimorfismo
{
    [TestClass]
    public class DiasAlVencimiento_ComoNumero_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private DatosBaseDeInversion losDatos;

        [TestMethod]
        public void ComoNumero_FechaDeVencimientoYActual_DiferenciaDeDias()
        {
            elResultadoEsperado = 221;

            losDatos = new DatosBaseDeInversion();
            losDatos.FechaDeVencimiento = new DateTime(2016, 10, 10);
            losDatos.FechaActual = new DateTime(2016, 3, 3);

            elResultadoObtenido = new DiasAlVencimiento(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
