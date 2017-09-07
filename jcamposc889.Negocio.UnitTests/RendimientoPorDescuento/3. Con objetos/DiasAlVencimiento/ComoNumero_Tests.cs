using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.RendimientoPorDescuento.ConObjetos;

namespace jcamposc889.Negocio.RendimientoPorDescuento.UnitTests.ConObjetos
{
    [TestClass]
    public class DiasAlVencimiento_ComoNumero_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;

        [TestMethod]
        public void ComoNumero_FechaDeVencimientoYActual_DiferenciaDeDias()
        {
            elResultadoEsperado = 221;
            elResultadoObtenido = new DiasAlVencimiento(new DateTime(2016, 10, 10), new DateTime(2016, 3, 3)).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
