using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.RendimientoPorDescuento.ConParameterObject;

namespace jcamposc889.Negocio.RendimientoPorDescuento.UnitTests.ConParameterObject
{
    [TestClass]
    public class TasaBruta_Calculado_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private DatosParaLaTasaBruta losDatos;

        [TestMethod]
        public void Calculado_SinTratamientoFiscal_SinRedondeo()
        {
            elResultadoEsperado = 12.2671;

            losDatos = new DatosParaLaTasaBruta();
            losDatos.ValorFacial = 320500;
            losDatos.ValorTransadoNeto = 300000;
            losDatos.TasaDeImpuesto = 0.08;
            losDatos.DiasAlVencimientoComoNumero = 221;

            elResultadoObtenido = new TasaBruta(losDatos).Calculado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
