namespace jcamposc889.Negocio.RendimientoPorDescuento.ConTellDontAsk
{
    public class DatosParaLaTasaBruta
    {
        public double elValorFacial { get; set; }
        public double elValorTransadoNeto { get; set; }
        public double laTasaDeImpuesto { get; set; }
        public double losDiasAlVencimientoComoNumero { get; set; }

        public double TasaNeta
        {
            get
            {
                return ((elValorFacial - elValorTransadoNeto) / (elValorTransadoNeto * 
                    (losDiasAlVencimientoComoNumero / 365))) * 100;
            }
        }
    }
}
