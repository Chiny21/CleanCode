using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo;

namespace jcamposc889.Negocio.UnitTests.EstructuraDeDatos.ConPolimorfismo.TasasNetasSinTratamiento
{
    [TestClass]
    public class ComoNumeroSinTratamiento_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private DatosParaLaInversionSinTratamiento losDatos;

        [TestMethod]
        public void ComoNumero_DatosCorrectos_TasaNetaCorrecta()
        {
            elResultadoEsperado = 11.0407;

            losDatos = new DatosParaLaInversionSinTratamiento();
            losDatos.ValorFacial = 320000;
            losDatos.ValorTransadoNeto = 300000;
            losDatos.TasaDeImpuesto = 0.08;
            losDatos.FechaActual = new DateTime(2016, 3, 3);
            losDatos.FechaDeVencimiento = new DateTime(2016, 10, 10);

            elResultadoObtenido = new TasaNetaSinTratamiento(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
