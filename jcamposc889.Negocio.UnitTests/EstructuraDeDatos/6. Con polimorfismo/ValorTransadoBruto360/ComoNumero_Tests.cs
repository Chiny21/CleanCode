﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo;

namespace jcamposc889.Negocio.UnitTests.EstructuraDeDatos.ConPolimorfismo.ValoresTransadosBrutosConTratamiento
{
    [TestClass]
    public class ComoNumero360_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private DatosParaLaInversion360 losDatos;

        [TestMethod]
        public void ComoNumero_DatosCorrectos_ValorTransadoBrutoCorrecta()
        {
            elResultadoEsperado = 298378.3783;

            losDatos = new DatosParaLaInversion360();
            losDatos.ValorFacial = 320000;
            losDatos.ValorTransadoNeto = 300000;
            losDatos.TasaDeImpuesto = 0.08;
            losDatos.FechaActual = new DateTime(2016, 3, 3);
            losDatos.FechaDeVencimiento = new DateTime(2016, 10, 10);

            elResultadoObtenido = new ValorTransadoBruto360(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
