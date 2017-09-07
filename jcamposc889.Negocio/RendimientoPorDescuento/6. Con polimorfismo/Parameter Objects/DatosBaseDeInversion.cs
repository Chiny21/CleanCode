using System;

namespace jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo
{
    public class DatosBaseDeInversion
    {
        public double ValorFacial { get; set; }
        public double ValorTransadoNeto { get; set; }
        public double TasaDeImpuesto { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
        public DateTime FechaActual { get; set; }
        public bool tieneTratamientoFiscal { get; set; }

        public TimeSpan DiferenciaEntreLasFechas
        {
            get
            {
                return FechaDeVencimiento - FechaActual;
            }
        }

    }
}