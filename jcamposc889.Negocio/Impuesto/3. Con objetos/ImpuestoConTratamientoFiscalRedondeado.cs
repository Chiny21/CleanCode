using System;

namespace jcamposc889.Negocio.Impuesto.ConObjetos
{
    public class ImpuestoConTratamientoFiscalRedondeado
    {
        private double elImpuestoConTratamientoFiscal;

        public ImpuestoConTratamientoFiscalRedondeado(double elValorFacial, 
            double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento,
            DateTime laFechaActual)
        {
            elImpuestoConTratamientoFiscal = ObtengaElImpuestoConTratamientoFiscal(elValorFacial, 
                elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual);
        }

        private double ObtengaElImpuestoConTratamientoFiscal(double elValorFacial,
            double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento,
            DateTime laFechaActual)
        {
            return new ImpuestoConTratamientoFiscal(elValorFacial, elValorTransadoNeto,
                laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual).Calculado();
        }

        public double Redondeado()
        {
            return RedondeeElImpuestoConTratamientoFiscal(elImpuestoConTratamientoFiscal);
        }

        private double RedondeeElImpuestoConTratamientoFiscal(double elImpuesto)
        {
            return Math.Round(elImpuesto, 4);
        }
    }
}
