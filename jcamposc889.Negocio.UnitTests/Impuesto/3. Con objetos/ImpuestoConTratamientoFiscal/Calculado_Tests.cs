using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.Impuesto.ConObjetos;

namespace jcamposc889.Negocio.Impuesto.UnitTests.ConObjetos
{
    [TestClass]
    public class ImpuestoConTratamientoFiscal_Calculado_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;

        [TestMethod]
        public void Calculado_TieneTratamientoFiscal_RedondeoHaciaAbajo()
        {
            elResultadoEsperado = 1621.6216;
            elResultadoObtenido = new ImpuestoConTratamientoFiscal(320000, 300000, 0.08, 
                new DateTime(2016, 10, 10), new DateTime(2016, 3, 3)).Calculado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
