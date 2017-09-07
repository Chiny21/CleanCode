namespace jcamposc889.Negocio.RendimientoPorDescuento.ConParameterObject
{
    public class TasaBruta
    {
        private double laTasaDeImpuesto;
        private double laTasaNeta;

        public TasaBruta(DatosParaLaTasaBruta losDatosParaLaTasaBruta)
        {
            // TODO: ARREGLAR ESTOS DETALLES
            laTasaDeImpuesto = losDatosParaLaTasaBruta.TasaDeImpuesto;
            laTasaNeta = CalculeLaTasaNeta(losDatosParaLaTasaBruta);
        }

        private double CalculeLaTasaNeta(DatosParaLaTasaBruta losDatosParaLaTasaBruta)
        {
            // TODO: HAY MAS DE UNA OPERACION
            return ((losDatosParaLaTasaBruta.ValorFacial - 
                losDatosParaLaTasaBruta.ValorTransadoNeto) /
                (losDatosParaLaTasaBruta.ValorTransadoNeto *
                (losDatosParaLaTasaBruta.DiasAlVencimientoComoNumero / 365))) * 100;
        }

        public double Calculado()
        {
            return laTasaNeta / (1 - laTasaDeImpuesto);

        }
    }
}
