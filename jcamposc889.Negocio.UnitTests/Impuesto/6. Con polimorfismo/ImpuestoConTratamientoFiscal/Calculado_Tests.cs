using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.Impuesto.ConPolimorfismo;
using jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo;

namespace jcamposc889.Negocio.Impuesto.UnitTests.ConPolimorfismo
{
    [TestClass]
    public class ImpuestoConTratamientoFiscal_Calculado_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private DatosDeInversionConTratamientoFiscal losDatos;


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

            elResultadoObtenido = new ImpuestoConTratamientoFiscal(losDatos).Calculado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 0.0001);
        }
    }
}
