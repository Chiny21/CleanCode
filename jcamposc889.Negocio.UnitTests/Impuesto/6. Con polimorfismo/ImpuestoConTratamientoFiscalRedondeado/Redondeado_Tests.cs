using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo;
using jcamposc889.Negocio.Impuesto.ConPolimorfismo;

namespace jcamposc889.Negocio.Impuesto.UnitTests.ConPolimorfismo
{
    [TestClass]
    public class ImpuestoConTratamientoFiscal_Redondeado_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private DatosDeInversionConTratamientoFiscal losDatos;
        private DatosDeInversion360 losDatos360;

        [TestMethod]
        public void Calculado_TieneTratamientoFiscal_RedondeoHaciaAbajo()
        {
            elResultadoEsperado = 1621.6216;

            losDatos = new DatosDeInversionConTratamientoFiscal();
            losDatos.ValorFacial = 320000;
            losDatos.ValorTransadoNeto = 300000;
            losDatos.TasaDeImpuesto = 0.08;
            losDatos.FechaDeVencimiento = new DateTime(2016, 10, 10);
            losDatos.FechaActual = new DateTime(2016, 3, 3);
            elResultadoObtenido = new ImpuestoConTratamientoFiscalRedondeado(losDatos).Redondeado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void Calculado_Tratamiento360_ImpuestoCorrecto()
        {
            elResultadoEsperado = 1621.6216;

            losDatos360 = new DatosDeInversion360();
            losDatos360.ValorFacial = 320000;
            losDatos360.ValorTransadoNeto = 300000;
            losDatos360.TasaDeImpuesto = 0.08;
            losDatos360.FechaDeVencimiento = new DateTime(2016, 10, 10);
            losDatos360.FechaActual = new DateTime(2016, 3, 3);
            elResultadoObtenido = new ImpuestoConTratamientoFiscalRedondeado(losDatos360).Redondeado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
