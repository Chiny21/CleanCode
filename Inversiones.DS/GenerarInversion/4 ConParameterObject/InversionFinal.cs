using System;
using jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo;
using Inversiones.DS.MapeoABaseDeDatos;

namespace Inversiones.DS.GenerarInversion.ConParameterObject
{
    class InversionFinal
    {
        private DatosParaLaInversion losDatos;

        public InversionFinal(DatosParaLaInversionFinal losDatosFinales)
        {
            losDatos = ObtengaLosDatos(losDatosFinales);
        }

        private DatosParaLaInversion ObtengaLosDatos(DatosParaLaInversionFinal losDatosFinales)
        {
            DatosParaLaInversion losDatos = DetermineElTipo(losDatosFinales);

            DateTime laFechaActual = ObtengaLaFechaActual();
            //TODO: ARREGLAR ESTOS DETALLES
            DatosParaLaFecha losDatosParaLaFecha = new DatosParaLaFecha();
            losDatosParaLaFecha.PlazoEnDias = losDatosFinales.PlazoEnDias;
            losDatosParaLaFecha.FechaActual = laFechaActual;

            losDatos.ValorFacial = losDatosFinales.ValorFacial;
            losDatos.ValorTransadoNeto = losDatosFinales.ValorTransadoNeto;
            losDatos.TasaDeImpuesto = ObtengaLaTasaDeImpuesto(laFechaActual);
            losDatos.FechaActual = laFechaActual;
            losDatos.FechaDeVencimiento = ObtengaLaFechaDeVencimiento(losDatosParaLaFecha);
            losDatos.ConsecutivoParaElCodigoDeReferencia = ObtengaElConsecutivoComoTexto(laFechaActual);

            return losDatos;
        }

        private DatosParaLaInversion DetermineElTipo(DatosParaLaInversionFinal losDatosFinales)
        {
            DatosParaLaInversion losDatos;

            switch (losDatosFinales.TipoDeInversion)
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

        private DateTime ObtengaLaFechaDeVencimiento(DatosParaLaFecha losDatosParaLaFecha)
        {
            //TODO: NO CUMPLE LA LEY DE DEMETER
            return losDatosParaLaFecha.FechaActual.AddDays(losDatosParaLaFecha.PlazoEnDias);
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
