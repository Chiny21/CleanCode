using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.EstructuraDeDatos.ConFunciones;

namespace jcamposc889.Negocio.UnitTests.EstructuraDeDatos.ConFunciones
{
    [TestClass]
    public class ImpuestoPagado_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private int elValorFacial;
        private int elValorTransadoNeto;
        private DateTime laFechaActual;
        private DateTime laFechaDeVencimiento;
        private double laTasaDeImpuesto;
        private bool tieneTratamientoFiscal;
        private string elConsecutivoParaElCodigoDeReferencia;
        private Inversion laInversion;

        [TestMethod]
        public void GenereUnaNuevaInversion_ConTratamientoFiscal_ImpuestoPagado()
        {
            elResultadoEsperado = 1621.6216;

            elValorFacial = 320000;
            elValorTransadoNeto = 300000;
            laTasaDeImpuesto = 0.08;
            laFechaActual = new DateTime(2016, 3, 3);
            laFechaDeVencimiento = new DateTime(2016, 10, 10);
            tieneTratamientoFiscal = true;
            elConsecutivoParaElCodigoDeReferencia = "888888888888";
            laInversion = Calculos.GenereUnaNuevaInversion(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento, tieneTratamientoFiscal, elConsecutivoParaElCodigoDeReferencia);

            elResultadoObtenido = laInversion.ImpuestoPagado;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }

        [TestMethod]
        public void GenereUnaNuevaInversion_SinTratamientoFiscal_ImpuestoPagado()
        {
            elResultadoEsperado = 0;

            elValorFacial = 320000;
            elValorTransadoNeto = 300000;
            laTasaDeImpuesto = 0.08;
            laFechaActual = new DateTime(2016, 3, 3);
            laFechaDeVencimiento = new DateTime(2016, 10, 10);
            tieneTratamientoFiscal = false;
            elConsecutivoParaElCodigoDeReferencia = "888888888888";
            laInversion = Calculos.GenereUnaNuevaInversion(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento, tieneTratamientoFiscal, elConsecutivoParaElCodigoDeReferencia);

            elResultadoObtenido = laInversion.ImpuestoPagado;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
