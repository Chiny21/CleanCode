using System;
using jcamposc889.Negocio.RendimientoPorDescuento.ConTellDontAsk;

namespace jcamposc889.Negocio.Impuesto.ConTellDontAsk
{
    public class ImpuestoConTratamientoFiscal
    {
        private double elValorTransadoNeto;
        private double elValorTransadoBruto;

        public ImpuestoConTratamientoFiscal(DatosParaElRendimientoPorDescuento losDatos)
        {
            elValorTransadoNeto = ExtraigaElValorTransadoNeto(losDatos);
            elValorTransadoBruto = GenereElValorTransadoBruto(losDatos);
        }

        private double ExtraigaElValorTransadoNeto(DatosParaElRendimientoPorDescuento losDatos)
        {
            return losDatos.ValorTransadoNeto;
        }

        private double GenereElValorTransadoBruto(DatosParaElRendimientoPorDescuento losDatos)
        {
            return new ValorTransadoBrutoConTratamientoFiscal(losDatos).ComoNumero();
        }

        public double Calculado()
        {
            return elValorTransadoNeto - elValorTransadoBruto;
        }
    }
}
