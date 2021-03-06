﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.EstructuraDeDatos.ComoUnProcedimiento;

namespace jcamposc889.Negocio.UnitTests.EstructuraDeDatos.ComoUnProcedimiento
{
    [TestClass]
    public class CodigoDeReferencia_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private int elValorFacial;
        private int elValorTransadoNeto;
        private DateTime laFechaActual;
        private DateTime laFechaDeVencimiento;
        private double laTasaDeImpuesto;
        private bool tieneTratamientoFiscal;
        private string elConsecutivoParaElCodigoDeReferencia;
        private Inversion laInversion;

        [TestMethod]
        public void GenereUnaNuevaInversion_CodigoDeReferencia()
        {
            elResultadoEsperado = "20160303022058888888888887";

            elValorFacial = 320000;
            elValorTransadoNeto = 300000;
            laTasaDeImpuesto = 0.08;
            laFechaActual = new DateTime(2016, 3, 3);
            laFechaDeVencimiento = new DateTime(2016, 10, 10);
            tieneTratamientoFiscal = true;
            elConsecutivoParaElCodigoDeReferencia = "888888888888";
            laInversion = Calculos.GenereUnaNuevaInversion(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento, tieneTratamientoFiscal, elConsecutivoParaElCodigoDeReferencia);

            elResultadoObtenido = laInversion.CodigoDeReferencia;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
