namespace jcamposc889.Negocio.RendimientoPorDescuento.ConObjetos
{
    public class TasaBruta
    {
        private double laTasaDeImpuesto;
        private double laTasaNeta;

        public TasaBruta(double elValorFacial, double elValorTransadoNeto,
            double laTasaDeImpuesto, double losDiasAlVencimientoComoNumero)
        {
            this.laTasaDeImpuesto = laTasaDeImpuesto;
            laTasaNeta = CalculeLaTasaNeta(elValorFacial, elValorTransadoNeto, losDiasAlVencimientoComoNumero);
        }

        private double CalculeLaTasaNeta(double elValorFacial, double elValorTransadoNeto,
            double losDiasAlVencimientoComoNumero)
        {
            return ((elValorFacial - elValorTransadoNeto) / (elValorTransadoNeto *
                (losDiasAlVencimientoComoNumero / 365))) * 100;
        }

        public double Calculado()
        {
            return laTasaNeta / (1 - laTasaDeImpuesto);
        }
    }
}
