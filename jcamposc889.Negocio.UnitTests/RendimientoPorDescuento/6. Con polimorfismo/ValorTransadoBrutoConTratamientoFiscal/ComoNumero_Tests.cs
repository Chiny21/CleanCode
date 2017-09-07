using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo;

namespace jcamposc889.Negocio.RendimientoPorDescuento.UnitTests.ConPolimorfismo
{
    [TestClass]
    public class ValorTransadoBrutoConTratamientoFiscal_ComoNumero_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private DatosDeInversionConTratamientoFiscal losDatos;

        [TestMethod]
        public void ComoNumero_ValorFacialTransadoNetoTasaImpuestoFechaActualYVencimiento_ValorTransadoBrutoCorrecto()
        {
            elResultadoEsperado = 298378.3783;

            losDatos = new DatosDeInversionConTratamientoFiscal();
            losDatos.ValorFacial = 320000;
            losDatos.ValorTransadoNeto = 300000;
            losDatos.TasaDeImpuesto = 0.08;
            losDatos.FechaDeVencimiento = new DateTime(2016,10,10);
            losDatos.FechaActual = new DateTime(2016,3,3);

            elResultadoObtenido = new ValorTransadoBrutoConTratamientoFiscal(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
