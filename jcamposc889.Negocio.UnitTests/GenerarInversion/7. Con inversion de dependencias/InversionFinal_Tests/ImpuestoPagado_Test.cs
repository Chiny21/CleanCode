using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inversiones.Negocio.GenerarInversion.ConInversionDeDependencias;
using NSubstitute;
using jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo;

namespace jcamposc889.Negocio.UnitTests.GenerarInversion.ConInversionDeDependencias.InversionFinal_Tests
{
    [TestClass]
    public class ImpuestoPagado_Test
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private Inversion laInversion;
        private DatosParaLaFecha losDatos;

        [TestMethod]
        public void ComoDatos_DatosParaLaFecha_ImpuestoPagadoConTratamiento()
        {
            elResultadoEsperado = 1621.6216;

            losDatos = Substitute.ForPartsOf<DatosParaLaFecha>();
            losDatos.ValorFacial = 320000;
            losDatos.ValorTransadoNeto = 300000;
            losDatos.PlazoEnDias = 221;
            losDatos.FechaActual.Returns(new DateTime(2016, 3, 3));
            losDatos.TasaDeImpuesto.Returns(0.08);
            losDatos.Consecutivo.Returns(888888888);
            losDatos.TipoDeDatos.Returns(new DatosParaLaInversionConTratamiento());

            laInversion = new InversionFinal(losDatos).ComoDatos();

            elResultadoObtenido = laInversion.ImpuestoPagado;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }

        [TestMethod]
        public void ComoDatos_DatosParaLaFecha_ImpuestoPagadoSinTratamiento()
        {
            elResultadoEsperado = 0;

            losDatos = Substitute.ForPartsOf<DatosParaLaFecha>();
            losDatos.ValorFacial = 320000;
            losDatos.ValorTransadoNeto = 300000;
            losDatos.PlazoEnDias = 221;
            losDatos.FechaActual.Returns(new DateTime(2016, 3, 3));
            losDatos.TasaDeImpuesto.Returns(0.08);
            losDatos.Consecutivo.Returns(888888888);
            losDatos.TipoDeDatos.Returns(new DatosParaLaInversionSinTratamiento());

            laInversion = new InversionFinal(losDatos).ComoDatos();

            elResultadoObtenido = laInversion.ImpuestoPagado;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }

        [TestMethod]
        public void ComoDatos_DatosParaLaFecha_ImpuestoPagado360()
        {
            elResultadoEsperado = 1621.6216;

            losDatos = Substitute.ForPartsOf<DatosParaLaFecha>();
            losDatos.ValorFacial = 320000;
            losDatos.ValorTransadoNeto = 300000;
            losDatos.PlazoEnDias = 221;
            losDatos.FechaActual.Returns(new DateTime(2016, 3, 3));
            losDatos.TasaDeImpuesto.Returns(0.08);
            losDatos.Consecutivo.Returns(888888888);
            losDatos.TipoDeDatos.Returns(new DatosParaLaInversion360());

            laInversion = new InversionFinal(losDatos).ComoDatos();

            elResultadoObtenido = laInversion.ImpuestoPagado;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
