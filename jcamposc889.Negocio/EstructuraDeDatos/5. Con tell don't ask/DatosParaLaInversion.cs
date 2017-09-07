using System;

namespace jcamposc889.Negocio.EstructuraDeDatos.ConTellDontAsk
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

        public double TasaNeta
        {
            get
            {
                if (tieneTratamientoFiscal)
                    return GenereLaTasaNetaConTratamiento();
                else
                    return GenereLaTasaNetaSinTratamiento();
            }
        }

        private double GenereLaTasaNetaConTratamiento()
        {
            return new TasaNetaConTratamiento(this).ComoNumero();
        }

        private double GenereLaTasaNetaSinTratamiento()
        {
            return new TasaNetaSinTratamiento(this).ComoNumero();
        }

        public double TasaBruta
        {
            get
            {
                if (tieneTratamientoFiscal)
                    return GenereLaTasaBrutaConTratamiento();
                else
                    return GenereLaTasaBrutaSinTratamiento();
            }
        }

        private double GenereLaTasaBrutaConTratamiento()
        {
            return new TasaBrutaConTratamiento(this).ComoNumero();
        }

        private double GenereLaTasaBrutaSinTratamiento()
        {
            return new TasaBrutaSinTratamiento(this).ComoNumero();
        }

        public double ValorTransadoBruto
        {
            get
            {
                if (tieneTratamientoFiscal)
                    return GenereElValorTransadoBrutoConTratamiento();
                else
                    return GenereElValorTransadoBrutoSinTratamiento();
            }
        }

        private double GenereElValorTransadoBrutoConTratamiento()
        {
            return new ValorTransadoBrutoConTratamiento(this).ComoNumero();
        }

        private double GenereElValorTransadoBrutoSinTratamiento()
        {
            return ValorTransadoNeto;
        }

        public double ImpuestoPagado
        {
            get
            {
                if (tieneTratamientoFiscal)
                    return GenereElImpuestoPagadoConTratamiento();
                else
                    return GenereElImpuestoPagadoSinTratamiento();
            }
        }

        private double GenereElImpuestoPagadoConTratamiento()
        {
            return new ImpuestoPagadoConTratamiento(this).ComoNumero();
        }

        private double GenereElImpuestoPagadoSinTratamiento()
        {
            return new ImpuestoPagadoSinTratamiento(this).ComoNumero();
        }

        public double RendimientoPorDescuento
        {
            get
            {
                if (tieneTratamientoFiscal)
                    return GenereElRendimientoPorDescuentoConTratamiento();
                else
                    return GenereElRendimientoPorDescuentoSinTratamiento();
            }
        }

        private double GenereElRendimientoPorDescuentoConTratamiento()
        {
            return new RendimientoPorDescuentoConTratamiento(this).ComoNumero();
        }

        private double GenereElRendimientoPorDescuentoSinTratamiento()
        {
            return new RendimientoPorDescuentoSinTratamiento(this).ComoNumero();
        }
    }
}
