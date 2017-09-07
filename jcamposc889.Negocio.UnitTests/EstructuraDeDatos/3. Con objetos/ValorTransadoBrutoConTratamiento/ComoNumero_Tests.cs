﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.EstructuraDeDatos.ConObjetos;


namespace jcamposc889.Negocio.UnitTests.EstructuraDeDatos.ConObjetos.ValoresTransadosBrutosConTratamiento
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

        [TestMethod]
        public void ComoNumero_DatosCorrectos_ValorTransadoBrutoCorrecta()
        {
            elResultadoEsperado = 298378.3783;

            elValorFacial = 320000;
            elValorTransadoNeto = 300000;
            laTasaDeImpuesto = 0.08;
            laFechaActual = new DateTime(2016, 3, 3);
            laFechaDeVencimiento = new DateTime(2016, 10, 10);

            elResultadoObtenido = new ValorTransadoBrutoConTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
