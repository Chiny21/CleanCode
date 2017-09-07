using System;
using jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo;
using Inversiones.DS.MapeoABaseDeDatos;
using Inversiones.Negocio.GenerarInversion.ConInversionDeDependencias;

namespace Inversiones.DS.GenerarInversion.ConInversionDeDependencias
{
    public class InversionSinTratamientoFiscal : DatosParaLaFecha
    {
        public override int Consecutivo
        {
            get
            {
                return new RepositorioDeParametros().ObtengaElConsecutivoParaElCodigoDeReferencia(FechaActual);
            }
        }

        public override DateTime FechaActual
        {
            get
            {
                return DateTime.Now;
            }
        }

        public override double TasaDeImpuesto
        {
            get
            {
                return new RepositorioDeParametros().ObtengaLaTasaDeimpuestoVigente(FechaActual);
            }
        }

        public override DatosParaLaInversion TipoDeDatos
        {
            get
            {
                return new DatosParaLaInversionSinTratamiento();
            }
        }
    }
}
