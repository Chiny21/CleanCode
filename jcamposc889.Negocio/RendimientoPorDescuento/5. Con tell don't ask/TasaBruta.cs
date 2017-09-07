using System;

namespace jcamposc889.Negocio.RendimientoPorDescuento.ConTellDontAsk
{
    public class TasaBruta
    {
        private double laTasaDeImpuesto;
        private double laTasaNeta;

        public TasaBruta(DatosParaLaTasaBruta losDatosParaLaTasaBruta)
        {
            laTasaDeImpuesto = ObtengaLaTasaDeImpuesto(losDatosParaLaTasaBruta);
            laTasaNeta = CalculeLaTasaNeta(losDatosParaLaTasaBruta);
        }

        private double ObtengaLaTasaDeImpuesto(DatosParaLaTasaBruta losDatosParaLaTasaBruta)
        {
            return losDatosParaLaTasaBruta.laTasaDeImpuesto;
        }

        private double CalculeLaTasaNeta(DatosParaLaTasaBruta losDatosParaLaTasaBruta)
        {
            return losDatosParaLaTasaBruta.TasaNeta;
        }

        public double Calculado()
        {
            return laTasaNeta / (1 - laTasaDeImpuesto);

        }
    }
}
