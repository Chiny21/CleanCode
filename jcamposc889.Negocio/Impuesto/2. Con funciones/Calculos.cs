using System;

namespace jcamposc889.Negocio.Impuesto.ConFunciones
{
    public static class Calculos
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

        private static double GenereElImpuestoConTratamientoFiscal(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            double elImpuesto = ObtengaElImpuestoConTratamientoFiscal(elValorFacial,
                                elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento,
                                laFechaActual);

            return RedondeeElImpuestoConTratamientoFiscal(elImpuesto);
        }

        private static double ObtengaElImpuestoConTratamientoFiscal(double elValorFacial,
            double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento,
            DateTime laFechaActual)
        {
            double elValorTransadoBruto = GenereElValorTransadoBruto(elValorFacial,
                elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual);

            return CalculeElImpuestoConTratamientoFiscal(elValorTransadoNeto,
                elValorTransadoBruto);
        }

        private static double GenereElValorTransadoBruto(double elValorFacial,
            double elValorTransadoNeto, double laTasaDeImpuesto,
            DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            double losDiasAlVencimientoComoNumero =
                GenereLosDiasAlVencimientoComoNumero(laFechaDeVencimiento, laFechaActual);

            double laTasaBruta = GenereLaTasaBruta(elValorFacial, elValorTransadoNeto,
                laTasaDeImpuesto, losDiasAlVencimientoComoNumero);

            return CalculeElValorTransadoBruto(elValorFacial, losDiasAlVencimientoComoNumero,
                laTasaBruta);
        }

        private static double GenereLosDiasAlVencimientoComoNumero(DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            TimeSpan losDiasAlVencimiento = CalculeLosDiasAlVencimiento(laFechaDeVencimiento,
                laFechaActual);

            return FormateeLosDiasAlVencimientoComoNumero(losDiasAlVencimiento);
        }

        private static TimeSpan CalculeLosDiasAlVencimiento(DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            return laFechaDeVencimiento - laFechaActual;
        }

        private static double FormateeLosDiasAlVencimientoComoNumero(TimeSpan losDiasAlVencimiento)
        {
            return losDiasAlVencimiento.Days;
        }

        private static double GenereLaTasaBruta(double elValorFacial, double elValorTransadoNeto,
            double laTasaDeImpuesto, double losDiasAlVencimientoComoNumero)
        {
            double laTasaNeta = CalculeLaTasaNeta(elValorFacial, elValorTransadoNeto,
                losDiasAlVencimientoComoNumero);

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

        private static double CalculeElValorTransadoBruto(double elValorFacial,
            double losDiasAlVencimientoComoNumero, double laTasaBruta)
        {
            return elValorFacial / (1 + ((laTasaBruta / 100) *
                (losDiasAlVencimientoComoNumero / 365)));
        }

        private static double CalculeElImpuestoConTratamientoFiscal(double elValorTransadoNeto,
            double elValorTransadoBruto)
        {
            return elValorTransadoNeto - elValorTransadoBruto;
        }

        private static double RedondeeElImpuestoConTratamientoFiscal(double elImpuesto)
        {
            return Math.Round(elImpuesto, 4);
        }

        private static double GenereElImpuestoSinTratamientoFiscal()
        {
            return 0;
        }
    }
}
