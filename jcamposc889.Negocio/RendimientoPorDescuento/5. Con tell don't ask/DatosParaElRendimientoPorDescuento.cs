using System;
using jcamposc889.Negocio.Impuesto.ConTellDontAsk;

namespace jcamposc889.Negocio.RendimientoPorDescuento.ConTellDontAsk
{
    public class DatosParaElRendimientoPorDescuento
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

        public double ValorTransadoBruto
        {
            get
            {
                if (tieneTratamientoFiscal)
                {
                    return ObtengaElValorTransadoBrutoConTratamientoFiscal();
                }
                else
                {
                    return ObtengaElValorTransadoBrutoSinTratamientoFiscal();
                }
            }
        }

        private double ObtengaElValorTransadoBrutoConTratamientoFiscal()
        {
            return new ValorTransadoBrutoConTratamientoFiscal(this).ComoNumero();
        }

        private double ObtengaElValorTransadoBrutoSinTratamientoFiscal()
        {
            return ValorTransadoNeto;
        }

        public double Impuesto
        {
            get
            {
                if (tieneTratamientoFiscal)
                {
                    return GenereElImpuestoConTratamientoFiscal();
                }
                else
                {
                    return GenereElImpuestoSinTratamientoFiscal();
                }
            }
        }

        private double GenereElImpuestoConTratamientoFiscal()
        {
            return new ImpuestoConTratamientoFiscalRedondeado(this).Redondeado();
        }

        private double GenereElImpuestoSinTratamientoFiscal()
        {
            return 0;
        }
    }
}