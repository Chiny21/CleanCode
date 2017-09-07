using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo;

namespace jcamposc889.Negocio.RendimientoPorDescuento.UnitTests.ConPolimorfismo
{
    [TestClass]
    public class TasaBruta_Calculado_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private DatosDeInversionSinTratamientoFiscal losDatos;

        [TestMethod]
        public void Calculado_SinTratamientoFiscal_SinRedondeo()
        {
            elResultadoEsperado = 12.3008;

            losDatos = new DatosDeInversionSinTratamientoFiscal();
            losDatos.ValorFacial = 320500;
            losDatos.ValorTransadoNeto = 300000;
            losDatos.TasaDeImpuesto = 0.08;
            losDatos.FechaDeVencimiento = new DateTime(2016, 10, 10);
            losDatos.FechaActual = new DateTime(2016, 3, 3);

            elResultadoObtenido = new TasaBruta(losDatos).Calculado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
