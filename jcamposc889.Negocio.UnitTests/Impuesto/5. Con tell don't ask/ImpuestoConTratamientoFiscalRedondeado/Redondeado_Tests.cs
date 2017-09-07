using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.RendimientoPorDescuento.ConTellDontAsk;
using jcamposc889.Negocio.Impuesto.ConTellDontAsk;

namespace jcamposc889.Negocio.Impuesto.UnitTests.ConTellDontAsk
{
    [TestClass]
    public class ImpuestoConTratamientoFiscal_Redondeado_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private DatosParaElRendimientoPorDescuento losDatos;

        [TestMethod]
        public void Calculado_TieneTratamientoFiscal_RedondeoHaciaAbajo()
        {
            elResultadoEsperado = 1621.6216;

            losDatos = new DatosParaElRendimientoPorDescuento();
            losDatos.ValorFacial = 320000;
            losDatos.ValorTransadoNeto = 300000;
            losDatos.TasaDeImpuesto = 0.08;
            losDatos.FechaDeVencimiento = new DateTime(2016, 10, 10);
            losDatos.FechaActual = new DateTime(2016, 3, 3);
            elResultadoObtenido = new ImpuestoConTratamientoFiscalRedondeado(losDatos).Redondeado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
