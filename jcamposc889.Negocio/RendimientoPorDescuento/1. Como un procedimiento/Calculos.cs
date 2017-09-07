using System;

namespace jcamposc889.Negocio.RendimientoPorDescuento.ComoUnProcedimiento
{
    public static class Calculos
    {
        public static double CalculeElRendimientoPorDescuento(double elValorFacial,
            double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento,
            DateTime laFechaActual, bool tieneTratamientoFiscal)
        {
            double elValorTransadoBruto;
            if (tieneTratamientoFiscal)
            {
                TimeSpan losDiasAlVencimiento = laFechaDeVencimiento - laFechaActual;
                double losDiasAlVencimientoComoNumero = losDiasAlVencimiento.Days;

                double laTasaNeta = ((elValorFacial - elValorTransadoNeto) /
                    (elValorTransadoNeto * (losDiasAlVencimientoComoNumero / 365))) * 100;

                double laTasaBruta = laTasaNeta / (1 - laTasaDeImpuesto);

                elValorTransadoBruto = elValorFacial / (1 + (laTasaBruta / 100) *
                    (losDiasAlVencimientoComoNumero / 365));
            }
            else
            {
                elValorTransadoBruto = elValorTransadoNeto;
            }

            double elRendimientoPorDescuento = elValorFacial - elValorTransadoBruto;

            return elRendimientoPorDescuento;
        }
    }
}
