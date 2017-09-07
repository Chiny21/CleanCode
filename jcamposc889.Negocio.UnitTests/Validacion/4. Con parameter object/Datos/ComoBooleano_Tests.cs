using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.Validacion.ConParameterObject;

namespace jcamposc889.Negocio.UnitTests.Validacion.ConParameterObject_Tests
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
            losDatos.elValorFacial = 100001;
            losDatos.elValorTransadoNeto = 100001;
            losDatos.laTasaDeImpuesto = 0.01;
            losDatos.laFechaActual = new DateTime(2016, 3, 3);
            losDatos.laFechaDeVencimiento = new DateTime(2016, 3, 4);

            elResultadoObtenido = new Datos(losDatos).SonValidos();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValideLosDatos_ValorFacialInvalido_False()
        {
            elResultadoEsperado = false;

            losDatos = new DatosParaVerificar();
            losDatos.elValorFacial = 100000;
            losDatos.elValorTransadoNeto = 100001;
            losDatos.laTasaDeImpuesto = 0.01;
            losDatos.laFechaActual = new DateTime(2016, 3, 3);
            losDatos.laFechaDeVencimiento = new DateTime(2016, 3, 4);

            elResultadoObtenido = new Datos(losDatos).SonValidos();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValideLosDatos_ValorTransadoNetoInvalido_False()
        {
            elResultadoEsperado = false;

            losDatos = new DatosParaVerificar();
            losDatos.elValorFacial = 100001;
            losDatos.elValorTransadoNeto = 100000;
            losDatos.laTasaDeImpuesto = 0.01;
            losDatos.laFechaActual = new DateTime(2016, 3, 3);
            losDatos.laFechaDeVencimiento = new DateTime(2016, 3, 4);

            elResultadoObtenido = new Datos(losDatos).SonValidos();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValideLosDatos_TasaDeImpuestoInvalidaConCero_False()
        {
            elResultadoEsperado = false;

            losDatos = new DatosParaVerificar();
            losDatos.elValorFacial = 100001;
            losDatos.elValorTransadoNeto = 100001;
            losDatos.laTasaDeImpuesto = 0;
            losDatos.laFechaActual = new DateTime(2016, 3, 3);
            losDatos.laFechaDeVencimiento = new DateTime(2016, 3, 4);

            elResultadoObtenido = new Datos(losDatos).SonValidos();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValideLosDatos_TasaDeImpuestoInvalidaConUno_False()
        {
            elResultadoEsperado = false;

            losDatos = new DatosParaVerificar();
            losDatos.elValorFacial = 100001;
            losDatos.elValorTransadoNeto = 100001;
            losDatos.laTasaDeImpuesto = 1;
            losDatos.laFechaActual = new DateTime(2016, 3, 3);
            losDatos.laFechaDeVencimiento = new DateTime(2016, 3, 4);

            elResultadoObtenido = new Datos(losDatos).SonValidos();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValideLosDatos_FechaActualInvalida_False()
        {
            elResultadoEsperado = false;

            losDatos = new DatosParaVerificar();
            losDatos.elValorFacial = 100001;
            losDatos.elValorTransadoNeto = 100001;
            losDatos.laTasaDeImpuesto = 0.01;
            losDatos.laFechaActual = new DateTime(2016, 3, 3);
            losDatos.laFechaDeVencimiento = new DateTime(2016, 3, 3);

            elResultadoObtenido = new Datos(losDatos).SonValidos();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
