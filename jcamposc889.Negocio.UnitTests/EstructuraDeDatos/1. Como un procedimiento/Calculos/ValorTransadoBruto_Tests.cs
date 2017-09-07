using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.EstructuraDeDatos.ComoUnProcedimiento;

namespace jcamposc889.Negocio.UnitTests.EstructuraDeDatos.ComoUnProcedimiento
{
    [TestClass]
    public class ValorTransadoBruto_Tests
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
        public void GenereUnaNuevaInversion_ConTratamientoFiscal_ValorTransadoBruto()
        {
            elResultadoEsperado = 298378.3784;

            elValorFacial = 320000;
            elValorTransadoNeto = 300000;
            laTasaDeImpuesto = 0.08;
            laFechaActual = new DateTime(2016, 3, 3);
            laFechaDeVencimiento = new DateTime(2016, 10, 10);
            tieneTratamientoFiscal = true;
            elConsecutivoParaElCodigoDeReferencia = "888888888888";
            laInversion = Calculos.GenereUnaNuevaInversion(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento, tieneTratamientoFiscal, elConsecutivoParaElCodigoDeReferencia);

            elResultadoObtenido = Math.Round(laInversion.ValorTransadoBruto, 4);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereUnaNuevaInversion_SinTratamientoFiscal_ValorTransadoBruto()
        {
            elResultadoEsperado = 300000;

            elValorFacial = 320000;
            elValorTransadoNeto = 300000;
            laTasaDeImpuesto = 0.08;
            laFechaActual = new DateTime(2016, 3, 3);
            laFechaDeVencimiento = new DateTime(2016, 10, 10);
            tieneTratamientoFiscal = false;
            elConsecutivoParaElCodigoDeReferencia = "888888888888";
            laInversion = Calculos.GenereUnaNuevaInversion(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento, tieneTratamientoFiscal, elConsecutivoParaElCodigoDeReferencia);

            elResultadoObtenido = Math.Round(laInversion.ValorTransadoBruto, 4);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
