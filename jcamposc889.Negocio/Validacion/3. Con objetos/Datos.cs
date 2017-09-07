using System;

namespace jcamposc889.Negocio.Validacion.ConObjetos
{
    public class Datos
    {
        private bool laValidezDelValorFacial;
        private bool laValidezDelValorTransadoNeto;
        private bool laValidezDeLaTasaDeImpuesto;
        private bool laValidezDeLaFechaActual;

        public Datos(double elValorFacial, double elValorTransadoNeto,
            double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento)
        {
            laValidezDelValorFacial = ValideElValorFacial(elValorFacial);
            laValidezDelValorTransadoNeto = ValideElValorTransadoNeto(elValorTransadoNeto);
            laValidezDeLaTasaDeImpuesto = ValideLaTasaDeImpuesto(laTasaDeImpuesto);
            laValidezDeLaFechaActual = ValideLaFechaActual(laFechaActual, laFechaDeVencimiento);
        }

        private bool ValideElValorFacial(double elValorFacial)
        {
            if (elValorFacialEsValido(elValorFacial))
                return RespondaVerdadero();
            else
                return RespondaFalso();
        }

        private bool elValorFacialEsValido(double elValorFacial)
        {
            return elValorFacial > 100000;
        }

        private bool ValideElValorTransadoNeto(double elValorTransadoNeto)
        {
            if (elValorTransadoNetoEsValido(elValorTransadoNeto))
                return RespondaVerdadero();
            else
                return RespondaFalso();
        }

        private bool elValorTransadoNetoEsValido(double elValorTransadoNeto)
        {
            return elValorTransadoNeto > 100000;
        }

        private bool ValideLaTasaDeImpuesto(double laTasaDeImpuesto)
        {
            if (laTasaDeImpuestoEsValida(laTasaDeImpuesto))
                return RespondaVerdadero();
            else
                return RespondaFalso();
        }

        private bool laTasaDeImpuestoEsValida(double laTasaDeImpuesto)
        {
            return laTasaDeImpuesto > 0 && laTasaDeImpuesto < 1;
        }

        private bool ValideLaFechaActual(DateTime laFechaActual,
            DateTime laFechaDeVencimiento)
        {
            if (LaFechaActualEsValida(laFechaActual, laFechaDeVencimiento))
                return RespondaVerdadero();
            else
                return RespondaFalso();
        }

        private bool LaFechaActualEsValida(DateTime laFechaActual, 
            DateTime laFechaDeVencimiento)
        {
            return laFechaActual < laFechaDeVencimiento;
        }

        public bool ComoBooleano()
        {
            return ValideLosDatos(laValidezDelValorFacial, laValidezDelValorTransadoNeto, 
                laValidezDeLaTasaDeImpuesto, laValidezDeLaFechaActual);
        }

        private bool ValideLosDatos(bool laValidezDelValorFacial,
            bool laValidezDelValorTransadoNeto, bool laValidezDeLaTasaDeImpuesto,
            bool laValidezDeLaFechaActual)
        {
            if (losDatosSonValidos(laValidezDelValorFacial, laValidezDelValorTransadoNeto,
                laValidezDeLaTasaDeImpuesto, laValidezDeLaFechaActual))
                return RespondaVerdadero();
            else
                return RespondaFalso();
        }

        private bool losDatosSonValidos(bool laValidezDelValorFacial, bool laValidezDelValorTransadoNeto, bool laValidezDeLaTasaDeImpuesto, bool laValidezDeLaFechaActual)
        {
            return laValidezDelValorFacial && laValidezDelValorTransadoNeto &&
                   laValidezDeLaTasaDeImpuesto && laValidezDeLaFechaActual;
        }

        private bool RespondaVerdadero()
        {
            return true;
        }

        private bool RespondaFalso()
        {
            return false;
        }
    }
}
