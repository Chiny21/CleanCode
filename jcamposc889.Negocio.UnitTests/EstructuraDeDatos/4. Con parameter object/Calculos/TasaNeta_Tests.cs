﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.EstructuraDeDatos.ConParameterObject;

namespace jcamposc889.Negocio.UnitTests.EstructuraDeDatos.ConParameterObject
{
    [TestClass]
    public class TasaNeta_Tests
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
        private DatosParaLaInversion losDatos;

        [TestMethod]
        public void GenereUnaNuevaInversion_TasaNeta()
        {
            elResultadoEsperado = 11.0407;

            losDatos = new DatosParaLaInversion();
            losDatos.ValorFacial = 320000;
            losDatos.ValorTransadoNeto = 300000;
            losDatos.TasaDeImpuesto = 0.08;
            losDatos.FechaActual = new DateTime(2016, 3, 3);
            losDatos.FechaDeVencimiento = new DateTime(2016, 10, 10);
            losDatos.tieneTratamientoFiscal = true;
            losDatos.ConsecutivoParaElCodigoDeReferencia = "888888888888";
            laInversion = Calculos.GenereUnaNuevaInversion(losDatos);

            elResultadoObtenido = Math.Round(laInversion.TasaNeta, 4);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
