﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.RendimientoPorDescuento.ConParameterObject;

namespace jcamposc889.Negocio.RendimientoPorDescuento.UnitTests.ConParameterObject
{
    [TestClass]
    public class CalculeElRendimientoPorDescuento_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private DatosParaElRendimientoPorDescuento losDatos;

        [TestMethod]
        public void CalculeElRendimientoPorDescuento_TieneTratamientoFiscal_RedondeoHaciaAbajo()
        {
            elResultadoEsperado = 21621.6216;

            losDatos = new DatosParaElRendimientoPorDescuento();
            losDatos.ValorFacial = 320000;
            losDatos.ValorTransadoNeto = 300000;
            losDatos.TasaDeImpuesto = 0.08;
            losDatos.FechaActual = new DateTime(2016, 10, 10);
            losDatos.FechaDeVencimiento = new DateTime(2016, 3, 3);
            losDatos.tieneTratamientoFiscal = true;

            elResultadoObtenido = new RendimientosPorDescuento(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }

        [TestMethod]
        public void CalculeElRendimientoPorDescuento_TieneTratamientoFiscal_RedondeoHaciaArriba()
        {
            elResultadoEsperado = 22159.3592;

            losDatos = new DatosParaElRendimientoPorDescuento();
            losDatos.ValorFacial = 320500;
            losDatos.ValorTransadoNeto = 300000;
            losDatos.TasaDeImpuesto = 0.08;
            losDatos.FechaActual = new DateTime(2016, 10, 10);
            losDatos.FechaDeVencimiento = new DateTime(2016, 3, 3);
            losDatos.tieneTratamientoFiscal = true;

            elResultadoObtenido = new RendimientosPorDescuento(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }

        [TestMethod]
        public void CalculeElRendimientoPorDescuento_SinTratamientoFiscal_SinRedondeo()
        {
            elResultadoEsperado = 19999.9999;

            losDatos = new DatosParaElRendimientoPorDescuento();
            losDatos.ValorFacial = 320000;
            losDatos.ValorTransadoNeto = 300000.0001;
            losDatos.TasaDeImpuesto = 0.08;
            losDatos.FechaActual = new DateTime(2016, 10, 10);
            losDatos.FechaDeVencimiento = new DateTime(2016, 3, 3);
            losDatos.tieneTratamientoFiscal = false;

            elResultadoObtenido = new RendimientosPorDescuento(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
