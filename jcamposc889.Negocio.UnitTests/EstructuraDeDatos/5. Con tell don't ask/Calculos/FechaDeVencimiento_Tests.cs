using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.EstructuraDeDatos.ConTellDontAsk;

namespace jcamposc889.Negocio.UnitTests.EstructuraDeDatos.ConTellDontAsk
{
    [TestClass]
    public class FechaDeVencimiento_Tests
    {
        private DateTime elResultadoEsperado;
        private DateTime elResultadoObtenido;
        private int elValorFacial;
        private int elValorTransadoNeto;
        private DateTime laFechaActual;
        private DateTime laFechaDeVencimiento;
        private double laTasaDeImpuesto;
        private bool tieneTratamientoFiscal;
        private string elConsecutivoParaElCodigoDeReferencia;
        private Inversion laInversion;
        private DatosParaLaInversion losDatos;

        [TestMethod]
        public void GenereUnaNuevaInversion_FechaDeVencimiento()
        {
            elResultadoEsperado = new DateTime(2016, 10, 10);

            losDatos = new DatosParaLaInversion();
            losDatos.ValorFacial = 320000;
            losDatos.ValorTransadoNeto = 300000;
            losDatos.TasaDeImpuesto = 0.08;
            losDatos.FechaActual = new DateTime(2016, 3, 3);
            losDatos.FechaDeVencimiento = new DateTime(2016, 10, 10);
            losDatos.tieneTratamientoFiscal = true;
            losDatos.ConsecutivoParaElCodigoDeReferencia = "888888888888";
            laInversion = Calculos.GenereUnaNuevaInversion(losDatos);

            elResultadoObtenido = laInversion.FechaDeVencimiento;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
