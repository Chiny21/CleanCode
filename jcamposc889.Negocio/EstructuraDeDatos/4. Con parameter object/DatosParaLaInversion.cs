using System;

namespace jcamposc889.Negocio.EstructuraDeDatos.ConParameterObject
{
    public class DatosParaLaInversion
    {
        public double ValorFacial { get; set; }
        public double ValorTransadoNeto { get; set; }
        public double TasaDeImpuesto { get; set; }
        public DateTime FechaActual { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
        public bool tieneTratamientoFiscal { get; set; }
        public string ConsecutivoParaElCodigoDeReferencia { get; set; }
    }
}
