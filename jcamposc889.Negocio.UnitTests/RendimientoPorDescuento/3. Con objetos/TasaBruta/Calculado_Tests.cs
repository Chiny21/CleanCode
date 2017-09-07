using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.RendimientoPorDescuento.ConObjetos;

namespace jcamposc889.Negocio.RendimientoPorDescuento.UnitTests.ConObjetos
{
    [TestClass]
    public class TasaBruta_Calculado_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;

        [TestMethod]
        public void Calculado_SinTratamientoFiscal_SinRedondeo()
        {
            elResultadoEsperado = 12.2671;
            elResultadoObtenido = new TasaBruta(320500, 300000, 0.08, 221).Calculado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
