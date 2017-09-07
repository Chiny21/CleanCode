using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.RendimientoPorDescuento.ConParameterObject;

namespace jcamposc889.Negocio.RendimientoPorDescuento.UnitTests.ConParameterObject
{
    [TestClass]
    public class DiasAlVencimiento_ComoNumero_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private DatosParaElRendimientoPorDescuento losDatos;

        [TestMethod]
        public void ComoNumero_FechaDeVencimientoYActual_DiferenciaDeDias()
        {
            elResultadoEsperado = 221;

            losDatos = new DatosParaElRendimientoPorDescuento();
            losDatos.FechaDeVencimiento = new DateTime(2016, 10, 10);
            losDatos.FechaActual = new DateTime(2016, 3, 3);

            elResultadoObtenido = new DiasAlVencimiento(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
