using System;
using Inversiones.DS.MapeoABaseDeDatos;

namespace Inversiones.DS.GenerarInversion.ConTellDontAsk
{
    public class DatosParaLaFecha
    {
        public int PlazoEnDias { get; set; }

        public DateTime FechaActual
        {
            get
            {
                return DateTime.Now;
            }
        }

        public DateTime FechaDeVencimiento
        {
            get
            {
                return FechaActual.AddDays(PlazoEnDias);
            }
        }

        public double TasaDeImpuesto
        {
            get
            {
                return new RepositorioDeParametros().ObtengaLaTasaDeimpuestoVigente(FechaActual);

            }
        }

        public string ConsecutivoComoTexto
        {
            get
            {
                return new ConsecutivoComoTexto(this).ComoTexto();
            }
        }

        public int Consecutivo
        {
            get
            {
                return new RepositorioDeParametros().ObtengaElConsecutivoParaElCodigoDeReferencia(FechaActual);
            }
        }
    }
}
