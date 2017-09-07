using System;
using jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo;
using Inversiones.DS.MapeoABaseDeDatos;

namespace Inversiones.DS.GenerarInversion.ConObjetos
{
    class InversionFinal
    {
        private DatosParaLaInversion losDatos;

        public InversionFinal(double elValorFacial,
            double elValorTransadoNeto, int elPlazoEnDias, TipoDeInversion elTipoDeInversion)
        {
            losDatos = ObtengaLosDatos(elValorFacial, elValorTransadoNeto, elPlazoEnDias, elTipoDeInversion);
        }

        private DatosParaLaInversion ObtengaLosDatos(double elValorFacial, double elValorTransadoNeto, int elPlazoEnDias, TipoDeInversion elTipoDeInversion)
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

        private DatosParaLaInversion DetermineElTipo(TipoDeInversion elTipoDeInversion)
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

        private double ObtengaLaTasaDeImpuesto(DateTime laFechaActual)
        {
            return new RepositorioDeParametros().ObtengaLaTasaDeimpuestoVigente(laFechaActual);
        }

        private DateTime ObtengaLaFechaActual()
        {
            return DateTime.Now;
        }

        private DateTime ObtengaLaFechaDeVencimiento(int elPlazoEnDias, DateTime laFechaActual)
        {
            return laFechaActual.AddDays(elPlazoEnDias);
        }

        private string ObtengaElConsecutivoComoTexto(DateTime laFechaActual)
        {
            return new ConsecutivoComoTexto(laFechaActual).ComoTexto();

        }

        public Inversion ComoDatos()
        {
            return new Inversion(losDatos);
        }
    }
}
