using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.RendimientoPorDescuento.ConObjetos;

namespace jcamposc889.Negocio.RendimientoPorDescuento.UnitTests.ConObjetos
{
    [TestClass]
    public class ValorTransadoBrutoConTratamientoFiscal_ComoNumero_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;

        [TestMethod]
        public void ComoNumero_ValorFacialTransadoNetoTasaImpuestoFechaActualYVencimiento_ValorTransadoBrutoCorrecto()
        {
            elResultadoEsperado = 298378.3783;

            double elValorFacial = 320000;
            double elValorTransadoNeto = 300000;
            double laTasaDeImpuesto = 0.08;
            DateTime laFechaDeVencimiento = new DateTime(2016,10,10);
            DateTime laFechaActual = new DateTime(2016,3,3);

            elResultadoObtenido = new ValorTransadoBrutoConTratamientoFiscal(elValorFacial, 
                elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, 
                laFechaActual).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
