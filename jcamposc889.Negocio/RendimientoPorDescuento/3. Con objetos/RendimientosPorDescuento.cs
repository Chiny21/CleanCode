using System;

namespace jcamposc889.Negocio.RendimientoPorDescuento.ConObjetos
{
    public class RendimientosPorDescuento
    {
        private double elValorTransadoBruto;
        private double elValorFacial;

        public RendimientosPorDescuento(double elValorFacial, double elValorTransadoNeto, 
            double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual, bool tieneTratamientoFiscal)
        {
            elValorTransadoBruto = GenereElValorTransadoBruto(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual, tieneTratamientoFiscal);
            this.elValorFacial = elValorFacial;
        }

        private double GenereElValorTransadoBruto(double elValorFacial,
           double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento,
           DateTime laFechaActual, bool tieneTratamientoFiscal)
        {
            if (tieneTratamientoFiscal)
            {
                return ObtengaElValorTransadoBrutoConTratamientoFiscal(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual);
            }
            else
            {
                return ObtengaElValorTransadoBrutoSinTratamientoFiscal(elValorTransadoNeto);
            }
        }

        private double ObtengaElValorTransadoBrutoConTratamientoFiscal(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            return new ValorTransadoBrutoConTratamientoFiscal(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual).ComoNumero();
        }

        private double ObtengaElValorTransadoBrutoSinTratamientoFiscal(double elValorTransadoNeto)
        {
            return elValorTransadoNeto;
        }

        public double ComoNumero()
        {
            return elValorFacial - elValorTransadoBruto;
        }
    }
}
