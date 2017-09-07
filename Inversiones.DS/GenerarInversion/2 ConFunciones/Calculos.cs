using jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo;
using Inversiones.DS.MapeoABaseDeDatos;
using System;

namespace Inversiones.DS.GenerarInversion.ConFunciones
{
    public static class Calculos
    {
        public static Inversion GenereLaInversion(double elValorFacial,
            double elValorTransadoNeto, int elPlazoEnDias, TipoDeInversion elTipoDeInversion)
        {
            DatosParaLaInversion losDatos = ObtengaLosDatos(elValorFacial, elValorTransadoNeto, elPlazoEnDias, elTipoDeInversion);

            return ObtengaLaInversion(losDatos);
        }

        private static DatosParaLaInversion ObtengaLosDatos(double elValorFacial, double elValorTransadoNeto, int elPlazoEnDias, TipoDeInversion elTipoDeInversion)
        {
            DatosParaLaInversion losDatos = DetermineElTipo(elTipoDeInversion);

            DateTime laFechaActual = ObtengaLaFechaActual();

            losDatos.ValorFacial = elValorFacial;
            losDatos.ValorTransadoNeto = elValorTransadoNeto;
            losDatos.TasaDeImpuesto = ObtengaLaTasaDeImpuesto(laFechaActual);
            losDatos.FechaActual = laFechaActual;
            losDatos.FechaDeVencimiento = ObtengaLaFechaDeVencimiento(elPlazoEnDias, laFechaActual);
            losDatos.ConsecutivoParaElCodigoDeReferencia = ObtengaElConsecutivoComoTexto(laFechaActual);

            return losDatos;
        }

        private static DatosParaLaInversion DetermineElTipo(TipoDeInversion elTipoDeInversion)
        {
            DatosParaLaInversion losDatos;

            switch (elTipoDeInversion)
            {
                case TipoDeInversion.ConTratamientoFiscal:
                    losDatos = new DatosParaLaInversionConTratamiento();
                    break;

                case TipoDeInversion.SinTratamientoFiscal:
                    losDatos = new DatosParaLaInversionSinTratamiento();
                    break;

                case TipoDeInversion.Tratamiento360:
                    losDatos = new DatosParaLaInversion360();
                    break;

                default:
                    throw new ArgumentException("Error: tipo de inversion invalido.");
            }
            return losDatos;
        }

        private static double ObtengaLaTasaDeImpuesto(DateTime laFechaActual)
        {
            return new RepositorioDeParametros().ObtengaLaTasaDeimpuestoVigente(laFechaActual);
        }

        private static DateTime ObtengaLaFechaActual()
        {
            return DateTime.Now;
        }

        private static DateTime ObtengaLaFechaDeVencimiento(int elPlazoEnDias, DateTime laFechaActual)
        {
            return laFechaActual.AddDays(elPlazoEnDias);
        }

        private static string ObtengaElConsecutivoComoTexto(DateTime laFechaActual)
        {
            int elConsecutivo = ObtengaElConsecutivo(laFechaActual);

            return ConviertaATexto(elConsecutivo);
        }

        private static int ObtengaElConsecutivo(DateTime laFechaActual)
        {
            return new RepositorioDeParametros().ObtengaElConsecutivoParaElCodigoDeReferencia(laFechaActual);
        }

        private static string ConviertaATexto(int elConsecutivo)
        {
            return elConsecutivo.ToString();
        }

        private static Inversion ObtengaLaInversion(DatosParaLaInversion losDatos)
        {
            return new Inversion(losDatos);
        }
    }
}
