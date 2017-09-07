using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jcamposc889.Negocio.Impuesto.UnitTests.ConParameterObject
{
    [TestClass]
    public class CalculeElImpuesto_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;

        [TestMethod]
        public void CalculeElImpuesto_TieneTratamientoFiscal_RedondeoHaciaAbajo()
        {
            elResultadoEsperado = 1621.6216;
            elResultadoObtenido = Impuesto.ConObjetos.Impuesto.CalculeElImpuesto(320000, 
                300000, 0.08, new DateTime(2016, 10, 10), new DateTime(2016, 3, 3), true);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void CalculeElImpuesto_TieneTratamientoFiscal_RedondeoHaciaArriba()
        {
            elResultadoEsperado = 1659.3592;
            elResultadoObtenido = Impuesto.ConObjetos.Impuesto.CalculeElImpuesto(320500,
                300000, 0.08, new DateTime(2016, 10, 10), new DateTime(2016, 3, 3), true);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void CalculeElImpuesto_SinTratamientoFiscal_EsCero()
        {
            elResultadoEsperado = 0;
            elResultadoObtenido = Impuesto.ConObjetos.Impuesto.CalculeElImpuesto(320000,
                300000.0001, 0.08, new DateTime(2016, 10, 10), new DateTime(2016, 3, 3), 
                false);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
