using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.RendimientoPorDescuento.ConTellDontAsk;

namespace jcamposc889.Negocio.RendimientoPorDescuento.UnitTests.ConTellDontAsk
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
            losDatos.elValorFacial = 320500;
            losDatos.elValorTransadoNeto = 300000;
            losDatos.laTasaDeImpuesto = 0.08;
            losDatos.losDiasAlVencimientoComoNumero = 221;

            elResultadoObtenido = new TasaBruta(losDatos).Calculado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
