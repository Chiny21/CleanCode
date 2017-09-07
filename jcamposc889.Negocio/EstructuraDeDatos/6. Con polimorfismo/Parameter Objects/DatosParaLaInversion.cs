using System;

namespace jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo
{
    public abstract class DatosParaLaInversion
    {
        public double ValorFacial { get; set; }
        public double ValorTransadoNeto { get; set; }
        public double TasaDeImpuesto { get; set; }
        public DateTime FechaActual { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
        public bool tieneTratamientoFiscal { get; set; }
        public string ConsecutivoParaElCodigoDeReferencia { get; set; }

        public string NumeroDelCliente
        {
            get
            {
                return "22";
            }
        }

        public string NumeroDelSistema
        {
            get
            {
                return "5";
            }
        }

        public abstract double TasaNeta { get; }

        public abstract double TasaBruta { get; }

        public abstract double ValorTransadoBruto { get; }

        public abstract double ImpuestoPagado { get; }

        public abstract double RendimientoPorDescuento { get; }
        
    }
}
