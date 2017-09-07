using System;

namespace jcamposc889.Negocio.CodigosDeReferencia.ConTellDontAsk
{
    public class DatosParaElRequerimiento
    {
        public DateTime Fecha { get; set; }
        public string NumeroDelCliente { get; set; }
        public string NumeroDelSistema { get; set; }
        public string NumeroConsecutivo { get; set; }

        public int AñoDeLaFecha
        {
            get
            {
                return Fecha.Year;
            }
        }

        public int MesDeLaFecha
        {
            get
            {
                return Fecha.Month;
            }
        }

        public int DiaDeLaFecha
        {
            get
            {
                return Fecha.Day;
            }
        }

        public string NumeroDelClienteFormateado
        {
            get
            {
                return NumeroDelCliente.PadLeft(3, '0');
            }
        }

        public string NumeroDelSistemaFormateado
        {
            get
            {
                return NumeroDelSistema.PadLeft(2, '0');
            }
        }

        public string NumeroConsecutivoFormateado
        {
            get
            {
                return NumeroConsecutivo.PadLeft(12, '0');
            }
        }
    }
}
