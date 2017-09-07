using jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo;
using System;

namespace Inversiones.DS.GenerarInversion.ConTellDontAsk
{
    public class DatosParaLaInversionFinal
    {
        public double ValorFacial { get; set; }
        public double ValorTransadoNeto { get; set; }
        public int PlazoEnDias { get; set; }
        public TipoDeInversion TipoDeInversion { get; set; }

        public DatosParaLaInversion TipoDeDatos
        {
            get
            {
                DatosParaLaInversion losDatos;

                switch (TipoDeInversion)
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
        }
    }
}
