using System;

namespace jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo
{
    public class TasaBruta
    {
        private double laTasaDeImpuesto;
        private double laTasaNeta;

        public TasaBruta(DatosDeInversion losDatosParaLaTasaBruta)
        {
            laTasaDeImpuesto = ObtengaLaTasaDeImpuesto(losDatosParaLaTasaBruta);
            laTasaNeta = CalculeLaTasaNeta(losDatosParaLaTasaBruta);
        }

        private double ObtengaLaTasaDeImpuesto(DatosDeInversion losDatosParaLaTasaBruta)
        {
            return losDatosParaLaTasaBruta.TasaDeImpuesto;
        }

        private double CalculeLaTasaNeta(DatosDeInversion losDatosParaLaTasaBruta)
        {
            return losDatosParaLaTasaBruta.TasaNeta;
        }

        public double Calculado()
        {
            return laTasaNeta / (1 - laTasaDeImpuesto);

        }
    }
}
