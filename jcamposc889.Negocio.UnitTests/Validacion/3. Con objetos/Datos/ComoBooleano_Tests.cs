﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.Validacion.ConObjetos;

namespace jcamposc889.Negocio.UnitTests.Validacion.ConObjetos_Tests
{
    [TestClass]
    public class Datos_ComoBooleano_Tests
    {
        private bool elResultadoEsperado;
        private bool elResultadoObtenido;
        private double elValorFacial;
        private double elValorTransadoNeto;
        private double laTasaDeImpuesto;
        private DateTime laFechaActual;
        private DateTime laFechaDeVencimiento;

        [TestMethod]
        public void ValideLosDatos_TodosLosDatosValidos_True()
        {
            elResultadoEsperado = true;

            elValorFacial = 150000;
            elValorTransadoNeto = 150000;
            laTasaDeImpuesto = 0.5;
            laFechaActual = new DateTime(2016, 3, 3);
            laFechaDeVencimiento = new DateTime(2016, 10, 10);

            elResultadoObtenido = new Datos(elValorFacial, elValorTransadoNeto,
                laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento).ComoBooleano();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValideLosDatos_ValorFacialInvalido_False()
        {
            elResultadoEsperado = false;

            elValorFacial = 80000;
            elValorTransadoNeto = 150000;
            laTasaDeImpuesto = 0.5;
            laFechaActual = new DateTime(2016, 3, 3);
            laFechaDeVencimiento = new DateTime(2016, 10, 10);

            elResultadoObtenido = new Datos(elValorFacial, elValorTransadoNeto,
                laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento).ComoBooleano();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
