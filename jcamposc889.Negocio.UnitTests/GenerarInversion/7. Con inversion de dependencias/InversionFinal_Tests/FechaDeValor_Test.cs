﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inversiones.Negocio.GenerarInversion.ConInversionDeDependencias;
using NSubstitute;
using jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo;

namespace jcamposc889.Negocio.UnitTests.GenerarInversion.ConInversionDeDependencias.InversionFinal_Tests
{
    [TestClass]
    public class FechaDeValor_Test
    {
        private DateTime elResultadoEsperado;
        private DateTime elResultadoObtenido;
        private Inversion laInversion;
        private DatosParaLaFecha losDatos;

        [TestMethod]
        public void ComoDatos_DatosParaLaFecha_FechaDeValor()
        {
            elResultadoEsperado = new DateTime(2016, 3, 3);

            losDatos = Substitute.ForPartsOf<DatosParaLaFecha>();
            losDatos.ValorFacial = 320000;
            losDatos.ValorTransadoNeto = 300000;
            losDatos.PlazoEnDias = 221;
            losDatos.FechaActual.Returns(new DateTime(2016, 3, 3));
            losDatos.TasaDeImpuesto.Returns(0.08);
            losDatos.Consecutivo.Returns(888888888);
            losDatos.TipoDeDatos.Returns(new DatosParaLaInversionConTratamiento());

            laInversion = new InversionFinal(losDatos).ComoDatos();

            elResultadoObtenido = laInversion.FechaDeValor;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
