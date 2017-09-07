using System;

namespace jcamposc889.Negocio.Validacion.ConTellDontAsk
{
    public class DatosParaVerificar
    {
        public double ValorFacial { get; set; }
        public double ValorTransadoNeto { get; set; }
        public double TasaDeImpuesto { get; set; }
        public DateTime FechaActual { get; set; }
        public DateTime FechaDeVencimiento { get; set; }

        public bool ElValorFacialEsValido()
        {
            if (ValorFacial > 100000)
                return true;
            else
                return false;
        }

        public bool ElValorTransadoNetoEsValido()
        {
            if (ValorTransadoNeto > 100000)
                return true;
            else
                return false;
        }

        public bool LaTasaDeImpuestoEsValida()
        {
            if (TasaDeImpuesto > 0 && TasaDeImpuesto < 1)
                return true;
            else
                return false;
        }

        public bool LaFechaActualEsValida()
        {
            if (FechaActual < FechaDeVencimiento)
                return true;
            else
                return false;
        }
    }
}