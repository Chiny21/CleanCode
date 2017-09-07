using System;

namespace jcamposc889.Negocio.Validacion.ComoUnProcedimiento
{
    public static class Calculos
    {
        public static bool ValideLosDatos(double elValorFacial, double elValorTransadoNeto,
            double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento)
        {
            bool laValidezDelValorFacial;
            if (elValorFacial > 100000)
                laValidezDelValorFacial = true;
            else
                laValidezDelValorFacial = false;

            bool laValidezDelValorTransadoNeto;
            if (elValorTransadoNeto > 100000)
                laValidezDelValorTransadoNeto = true;
            else
                laValidezDelValorTransadoNeto = false;

            bool laValidezDeLaTasaDeImpuesto;
            if (laTasaDeImpuesto > 0 && laTasaDeImpuesto < 1)
                laValidezDeLaTasaDeImpuesto = true;
            else
                laValidezDeLaTasaDeImpuesto = false;

            bool laValidezDeLaFechaActual;
            if (laFechaActual < laFechaDeVencimiento)
                laValidezDeLaFechaActual = true;
            else
                laValidezDeLaFechaActual = false;

            bool laValidezDeLosDatos;
            if (laValidezDelValorFacial && laValidezDelValorTransadoNeto && 
                laValidezDeLaTasaDeImpuesto && laValidezDeLaFechaActual)
                laValidezDeLosDatos = true;
            else
                laValidezDeLosDatos = false;

            return laValidezDeLosDatos;
        }
    }
}
