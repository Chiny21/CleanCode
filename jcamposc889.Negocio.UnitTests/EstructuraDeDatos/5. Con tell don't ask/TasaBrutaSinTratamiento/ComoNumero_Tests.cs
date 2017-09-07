﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.EstructuraDeDatos.ConTellDontAsk;


namespace jcamposc889.Negocio.UnitTests.EstructuraDeDatos.ConTellDontAsk.TasasBrutasSinTratamiento
{
    [TestClass]
    public class ComoNumeroConTratamiento_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private int elValorFacial;
        private int elValorTransadoNeto;
        private DateTime laFechaActual;
        private DateTime laFechaDeVencimiento;
        private double laTasaDeImpuesto;
        private DatosParaLaInversion losDatos;

        [TestMethod]
        public void ComoNumero_DatosCorrectos_TasaBrutaCorrecta()
        {
            elResultadoEsperado = 12.0007;

            losDatos = new DatosParaLaInversion();
            losDatos.ValorFacial = 320000;
            losDatos.ValorTransadoNeto = 300000;
            losDatos.TasaDeImpuesto = 0.08;
            losDatos.FechaActual = new DateTime(2016, 3, 3);
            losDatos.FechaDeVencimiento = new DateTime(2016, 10, 10);

            elResultadoObtenido = new TasaBrutaSinTratamiento(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
