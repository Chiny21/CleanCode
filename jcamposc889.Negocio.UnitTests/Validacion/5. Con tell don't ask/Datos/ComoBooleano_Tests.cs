using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.Validacion.ConTellDontAsk;

namespace jcamposc889.Negocio.UnitTests.Validacion.ConTellDontAsk_Tests
{
    [TestClass]
    public class Datos_ComoBooleano_Tests
    {
        private bool elResultadoEsperado;
        private bool elResultadoObtenido;
        DatosParaVerificar losDatos;

        [TestMethod]
        public void ValideLosDatos_TodosLosDatosValidos_True()
        {
            elResultadoEsperado = true;

            losDatos = new DatosParaVerificar();
            losDatos.ValorFacial = 100001;
            losDatos.ValorTransadoNeto = 100001;
            losDatos.TasaDeImpuesto = 0.01;
            losDatos.FechaActual = new DateTime(2016, 3, 3);
            losDatos.FechaDeVencimiento = new DateTime(2016, 3, 4);

            elResultadoObtenido = new Datos(losDatos).SonValidos();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValideLosDatos_ValorFacialInvalido_False()
        {
            elResultadoEsperado = false;

            losDatos = new DatosParaVerificar();
            losDatos.ValorFacial = 100000;
            losDatos.ValorTransadoNeto = 100001;
            losDatos.TasaDeImpuesto = 0.01;
            losDatos.FechaActual = new DateTime(2016, 3, 3);
            losDatos.FechaDeVencimiento = new DateTime(2016, 3, 4);

            elResultadoObtenido = new Datos(losDatos).SonValidos();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValideLosDatos_ValorTransadoNetoInvalido_False()
        {
            elResultadoEsperado = false;

            losDatos = new DatosParaVerificar();
            losDatos.ValorFacial = 100001;
            losDatos.ValorTransadoNeto = 100000;
            losDatos.TasaDeImpuesto = 0.01;
            losDatos.FechaActual = new DateTime(2016, 3, 3);
            losDatos.FechaDeVencimiento = new DateTime(2016, 3, 4);

            elResultadoObtenido = new Datos(losDatos).SonValidos();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValideLosDatos_TasaDeImpuestoInvalidaConCero_False()
        {
            elResultadoEsperado = false;

            losDatos = new DatosParaVerificar();
            losDatos.ValorFacial = 100001;
            losDatos.ValorTransadoNeto = 100001;
            losDatos.TasaDeImpuesto = 0;
            losDatos.FechaActual = new DateTime(2016, 3, 3);
            losDatos.FechaDeVencimiento = new DateTime(2016, 3, 4);

            elResultadoObtenido = new Datos(losDatos).SonValidos();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValideLosDatos_TasaDeImpuestoInvalidaConUno_False()
        {
            elResultadoEsperado = false;

            losDatos = new DatosParaVerificar();
            losDatos.ValorFacial = 100001;
            losDatos.ValorTransadoNeto = 100001;
            losDatos.TasaDeImpuesto = 1;
            losDatos.FechaActual = new DateTime(2016, 3, 3);
            losDatos.FechaDeVencimiento = new DateTime(2016, 3, 4);

            elResultadoObtenido = new Datos(losDatos).SonValidos();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValideLosDatos_FechaActualInvalida_False()
        {
            elResultadoEsperado = false;

            losDatos = new DatosParaVerificar();
            losDatos.ValorFacial = 100001;
            losDatos.ValorTransadoNeto = 100001;
            losDatos.TasaDeImpuesto = 0.01;
            losDatos.FechaActual = new DateTime(2016, 3, 3);
            losDatos.FechaDeVencimiento = new DateTime(2016, 3, 3);

            elResultadoObtenido = new Datos(losDatos).SonValidos();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
