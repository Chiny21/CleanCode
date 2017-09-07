using jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo;
using Inversiones.DS.MapeoABaseDeDatos;
using System;

namespace Inversiones.DS.GenerarInversion.ComoUnProcedimiento
{
    public static class Calculos
    {
        public static Inversion GenereLaInversion(double elValorFacial,
            double elValorTransadoNeto, int elPlazoEnDias, TipoDeInversion elTipoDeInversion)
        {
            //VALIDACION DE LOS DATOS

            if (elValorFacial <= 100000)
            {
                throw new ArgumentException("Error: El valor facial es invalido.");
            }

            if (elValorTransadoNeto <= 100000)
            {
                throw new ArgumentException("Error: El valor transado neto es invalido.");
            }

            if (elPlazoEnDias < 1)
            {
                throw new ArgumentException("Error: El plazo en dias es invalido.");
            }

            //DEPENDENCIAS CON RECURSOS EXTERNOS

            DateTime laFechaActual = DateTime.Now;
            double laTasaDeImpuesto = new RepositorioDeParametros().ObtengaLaTasaDeimpuestoVigente(laFechaActual);
            int elConsecutivo = new RepositorioDeParametros().ObtengaElConsecutivoParaElCodigoDeReferencia(laFechaActual);

            //ASIGNACION DE LAS PROPIEDADES

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

            //ASIGNACION DE TODOS LOS DATOS PARA LA INVERSION
            losDatos.ValorFacial = elValorFacial;
            losDatos.ValorTransadoNeto = elValorTransadoNeto;
            losDatos.TasaDeImpuesto = laTasaDeImpuesto;
            losDatos.FechaActual = laFechaActual;

            DateTime laFechaDeVencimiento = laFechaActual.AddDays(elPlazoEnDias);
            losDatos.FechaDeVencimiento = laFechaDeVencimiento;

            string elConsecutivoComoTexto = elConsecutivo.ToString();
            losDatos.ConsecutivoParaElCodigoDeReferencia = elConsecutivoComoTexto;

            return new Inversion(losDatos);
        }
    }
}
