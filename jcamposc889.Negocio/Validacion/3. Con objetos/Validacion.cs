using System;

namespace jcamposc889.Negocio.Validacion.ConObjetos
{
    public static class Validaciones
    {
        public static bool VerifiqueLosDatos(double elValorFacial,
            double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaActual,
            DateTime laFechaDeVencimiento)
        {
            return new Datos(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto,
                laFechaActual, laFechaDeVencimiento).ComoBooleano();
        }
    }
}
