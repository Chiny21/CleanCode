using System;

namespace jcamposc889.Negocio.RendimientoPorDescuento.ConFunciones
{
    public static class Calculos
    {
        public static double CalculeElRendimientoPorDescuento(double elValorFacial,
            double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento,
            DateTime laFechaActual, bool tieneTratamientoFiscal)
        {
            double elValorTransadoBruto = GenereElValorTransadoBruto(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual, tieneTratamientoFiscal);

            return GenereElRendimientoPorDescuento(elValorFacial, elValorTransadoBruto);
        }

        private static double GenereElValorTransadoBruto(double elValorFacial, 
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

        private static double ObtengaElValorTransadoBrutoConTratamientoFiscal(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            double losDiasAlVencimientoComoNumero = GenereLosDiasAlVencimientoComoNumero(laFechaDeVencimiento, laFechaActual);
            double laTasaBruta = GenereLaTasaBruta(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, losDiasAlVencimientoComoNumero);

            return CalculeElValorTransadoBrutoConTratamientoFiscal(elValorFacial, losDiasAlVencimientoComoNumero, laTasaBruta);
        }

        private static double GenereLosDiasAlVencimientoComoNumero(DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            TimeSpan losDiasAlVencimiento = CalculeLosDiasAlVencimiento(laFechaDeVencimiento, laFechaActual);

            return ObtengaLosDiasAlVencimientoComoNumero(losDiasAlVencimiento);
        }

        private static TimeSpan CalculeLosDiasAlVencimiento(DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            return laFechaDeVencimiento - laFechaActual;
        }

        private static double ObtengaLosDiasAlVencimientoComoNumero(TimeSpan losDiasAlVencimiento)
        {
            return losDiasAlVencimiento.Days;
        }

        private static double GenereLaTasaBruta(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, double losDiasAlVencimientoComoNumero)
        {
            double laTasaNeta = CalculeLaTasaNeta(elValorFacial, elValorTransadoNeto, losDiasAlVencimientoComoNumero);

            return CalculeLaTasaBruta(laTasaDeImpuesto, laTasaNeta);
        }

        private static double CalculeLaTasaNeta(double elValorFacial, double elValorTransadoNeto, double losDiasAlVencimientoComoNumero)
        {
            return ((elValorFacial - elValorTransadoNeto) / (elValorTransadoNeto * 
                (losDiasAlVencimientoComoNumero / 365))) * 100;
        }

        private static double CalculeLaTasaBruta(double laTasaDeImpuesto, double laTasaNeta)
        {
            return laTasaNeta / (1 - laTasaDeImpuesto);
        }

        private static double CalculeElValorTransadoBrutoConTratamientoFiscal(double elValorFacial, double losDiasAlVencimientoComoNumero, double laTasaBruta)
        {
            return elValorFacial / (1 + (laTasaBruta / 100) * (losDiasAlVencimientoComoNumero / 365));
        }

        private static double ObtengaElValorTransadoBrutoSinTratamientoFiscal(double elValorTransadoNeto)
        {
            return elValorTransadoNeto;
        }

        private static double GenereElRendimientoPorDescuento(double elValorFacial, double elValorTransadoBruto)
        {
            return elValorFacial - elValorTransadoBruto;
        }
    }
}
