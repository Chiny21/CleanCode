using System;


namespace jcamposc889.Negocio.Impuesto.ConObjetos
{
    public static class Impuesto
    {
        public static double CalculeElImpuesto(double elValorFacial, double elValorTransadoNeto,
            double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual,
            bool tieneTratamientoFiscal)
        {
            if (tieneTratamientoFiscal)
            {
                return GenereElImpuestoConTratamientoFiscal(elValorFacial, elValorTransadoNeto, 
                    laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual);
            }
            else
            {
                return GenereElImpuestoSinTratamientoFiscal();
            }
        }

        private static double GenereElImpuestoConTratamientoFiscal(double elValorFacial, 
            double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, 
            DateTime laFechaActual)
        {
            return new ImpuestoConTratamientoFiscalRedondeado(elValorFacial, elValorTransadoNeto,
                laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual).Redondeado();
        }

        private static double GenereElImpuestoSinTratamientoFiscal()
        {
            return 0;
        }
    }
}
