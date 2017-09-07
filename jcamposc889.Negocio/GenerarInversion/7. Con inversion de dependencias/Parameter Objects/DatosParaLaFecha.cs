using System;

namespace Inversiones.Negocio.GenerarInversion.ConInversionDeDependencias
{
    public abstract class DatosParaLaFecha : DatosParaLaInversionFinal
    {
        public DateTime FechaDeVencimiento
        {
            get
            {
                return FechaActual.AddDays(PlazoEnDias);
            }
        }

        public string ConsecutivoComoTexto
        {
            get
            {
                return new ConsecutivoComoTexto(this).ComoTexto();
            }
        }

        public abstract DateTime FechaActual { get; }

        public abstract double TasaDeImpuesto { get; }

        public abstract int Consecutivo { get; }
    }
}
