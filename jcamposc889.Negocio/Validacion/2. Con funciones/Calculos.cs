using System;

namespace jcamposc889.Negocio.Validacion.ConFunciones
{
    public static class Calculos
    {
        public static bool VerifiqueLosDatos(double elValorFacial, double elValorTransadoNeto,
            double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento)
        {
            bool laValidezDelValorFacial = ValideElValorFacial(elValorFacial);
            bool laValidezDelValorTransadoNeto = ValideElValorTransadoNeto(elValorTransadoNeto);
            bool laValidezDeLaTasaDeImpuesto = ValideLaTasaDeImpuesto(laTasaDeImpuesto);
            bool laValidezDeLaFechaActual = ValideLaFechaActual(laFechaActual,
                laFechaDeVencimiento);

            return ValideLosDatos(laValidezDelValorFacial, laValidezDelValorTransadoNeto,
                laValidezDeLaTasaDeImpuesto, laValidezDeLaFechaActual);
        }

        private static bool ValideElValorFacial(double elValorFacial)
        {
            if (elValorFacialEsValido(elValorFacial))
                return RespondaVerdadero();
            else
                return RespondaFalso();
        }

        private static bool elValorFacialEsValido(double elValorFacial)
        {
            return elValorFacial > 100000;
        }

        private static bool ValideElValorTransadoNeto(double elValorTransadoNeto)
        {
            if (elValorTransadoNetoEsValido(elValorTransadoNeto))
                return RespondaVerdadero();
            else
                return RespondaFalso();
        }

        private static bool elValorTransadoNetoEsValido(double elValorTransadoNeto)
        {
            return elValorTransadoNeto > 100000;
        }

        private static bool ValideLaTasaDeImpuesto(double laTasaDeImpuesto)
        {
            if (laTasaDeImpuestoEsValida(laTasaDeImpuesto))
                return RespondaVerdadero();
            else
                return RespondaFalso();
        }

        private static bool laTasaDeImpuestoEsValida(double laTasaDeImpuesto)
        {
            return laTasaDeImpuesto > 0 && laTasaDeImpuesto < 1;
        }

        private static bool ValideLaFechaActual(DateTime laFechaActual, 
            DateTime laFechaDeVencimiento)
        {
            if (LaFechaActualEsValida(laFechaActual, laFechaDeVencimiento))
                return RespondaVerdadero();
            else
                return RespondaFalso();
        }

        private static bool LaFechaActualEsValida(DateTime laFechaActual, DateTime laFechaDeVencimiento)
        {
            return laFechaActual < laFechaDeVencimiento;
        }

        private static bool ValideLosDatos(bool laValidezDelValorFacial,
            bool laValidezDelValorTransadoNeto, bool laValidezDeLaTasaDeImpuesto,
            bool laValidezDeLaFechaActual)
        {
            if (losDatosSonValidos(laValidezDelValorFacial, laValidezDelValorTransadoNeto, 
                laValidezDeLaTasaDeImpuesto, laValidezDeLaFechaActual))
                return RespondaVerdadero();
            else
                return RespondaFalso();
        }

        private static bool losDatosSonValidos(bool laValidezDelValorFacial, bool laValidezDelValorTransadoNeto, bool laValidezDeLaTasaDeImpuesto, bool laValidezDeLaFechaActual)
        {
            return laValidezDelValorFacial && laValidezDelValorTransadoNeto &&
                   laValidezDeLaTasaDeImpuesto && laValidezDeLaFechaActual;
        }

        private static bool RespondaVerdadero()
        {
            return true;
        }

        private static bool RespondaFalso()
        {
            return false;
        }
    }
}
