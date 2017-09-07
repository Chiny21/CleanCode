using System;
using jcamposc889.Negocio.RendimientoPorDescuento.ConObjetos;

namespace jcamposc889.Negocio.Impuesto.ConObjetos
{
    public class ImpuestoConTratamientoFiscal
    {
        private double elValorTransadoNeto;
        private double elValorTransadoBruto;

        public ImpuestoConTratamientoFiscal(double elValorFacial, double elValorTransadoNeto, 
            double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            this.elValorTransadoNeto = elValorTransadoNeto;
            elValorTransadoBruto = GenereElValorTransadoBruto(elValorFacial,
                elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual);
        }

        private double GenereElValorTransadoBruto(double elValorFacial,
            double elValorTransadoNeto, double laTasaDeImpuesto,
            DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            return new ValorTransadoBrutoConTratamientoFiscal(elValorFacial, elValorTransadoNeto,
                laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual).ComoNumero();
        }

        public double Calculado()
        {
            return CalculeElImpuestoConTratamientoFiscal(elValorTransadoNeto,
                elValorTransadoBruto);
        }

        private double CalculeElImpuestoConTratamientoFiscal(double elValorTransadoNeto,
            double elValorTransadoBruto)
        {
            return elValorTransadoNeto - elValorTransadoBruto;
        }
    }
}
