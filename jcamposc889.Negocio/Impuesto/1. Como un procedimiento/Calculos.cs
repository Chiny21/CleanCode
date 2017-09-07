using System;
        
namespace jcamposc889.Negocio.Impuesto.ComoUnProcedimiento
{
    public static class Calculos
    {
        public static double CalculeElImpuesto(double elValorFacial, double elValorTransadoNeto,
            double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual,
            bool tieneTratamientoFiscal)
        {
            double elImpuestoFormateado;

            if (tieneTratamientoFiscal)
            {
                TimeSpan losDiasAlVencimiento = laFechaDeVencimiento - laFechaActual;
                double losDiasAlVencimientoComoNumero = losDiasAlVencimiento.Days;

                double laTasaNeta = ((elValorFacial - elValorTransadoNeto) / 
                    (elValorTransadoNeto * (losDiasAlVencimientoComoNumero / 365))) *100;

                double laTasaBruta = laTasaNeta / (1 - laTasaDeImpuesto);

                double elValorTransadoBruto = elValorFacial / (1 + 
                    ((laTasaBruta / 100) * (losDiasAlVencimientoComoNumero / 365)));

                double elImpuesto = elValorTransadoNeto - elValorTransadoBruto;

                elImpuestoFormateado = Math.Round(elImpuesto, 4);

            } else
            {
                elImpuestoFormateado = 0;
            }

            return elImpuestoFormateado; 
        }
    }
}
