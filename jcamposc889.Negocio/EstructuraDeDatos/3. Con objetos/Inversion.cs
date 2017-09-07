using System;

namespace jcamposc889.Negocio.EstructuraDeDatos.ConObjetos
{
    public class Inversion
    {
        public string CodigoDeReferencia { get; set; }
        public double TasaNeta { get; set; }
        public double TasaBruta { get; set; }
        public double ValorTransadoBruto { get; set; }
        public double ImpuestoPagado { get; set; }
        public double RendimientoPorDescuento { get; set; }
        public DateTime FechaDeValor { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
    }
}