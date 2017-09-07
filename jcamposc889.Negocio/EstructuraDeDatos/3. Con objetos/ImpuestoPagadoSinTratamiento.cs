using jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo;
using System;

namespace jcamposc889.Negocio.EstructuraDeDatos.ConObjetos
{
    public class ImpuestoPagadoSinTratamiento
    {
        DatosDeInversionSinTratamientoFiscal losDatosSinTratamiento;

        public ImpuestoPagadoSinTratamiento(double elValorFacial, double elValorTransadoNeto,
            double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento)
        {
            losDatosSinTratamiento = AsigneLosDatosSinTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento);
        }

        private DatosDeInversionSinTratamientoFiscal AsigneLosDatosSinTratamiento(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento)
        {
            DatosDeInversionSinTratamientoFiscal losDatosSinTratamiento = new DatosDeInversionSinTratamientoFiscal();

            losDatosSinTratamiento.ValorFacial = elValorFacial;
            losDatosSinTratamiento.ValorTransadoNeto = elValorTransadoNeto;
            losDatosSinTratamiento.TasaDeImpuesto = laTasaDeImpuesto;
            losDatosSinTratamiento.FechaActual = laFechaActual;
            losDatosSinTratamiento.FechaDeVencimiento = laFechaDeVencimiento;

            return losDatosSinTratamiento;
        }

        public double ComoNumero()
        {
            return losDatosSinTratamiento.Impuesto;
        }
    }
}
