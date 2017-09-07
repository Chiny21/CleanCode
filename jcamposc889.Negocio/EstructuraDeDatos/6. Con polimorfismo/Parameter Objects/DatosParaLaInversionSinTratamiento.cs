namespace jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo
{
    public class DatosParaLaInversionSinTratamiento : DatosParaLaInversion
    {
        public override double ImpuestoPagado
        {
            get
            {
                return new ImpuestoPagadoSinTratamiento(this).ComoNumero();
            }
        }

        public override double RendimientoPorDescuento
        {
            get
            {
                return new RendimientoPorDescuentoSinTratamiento(this).ComoNumero();
            }
        }

        public override double TasaBruta
        {
            get
            {
                return new TasaBrutaSinTratamiento(this).ComoNumero();
            }
        }

        public override double TasaNeta
        {
            get
            {
                return new TasaNetaSinTratamiento(this).ComoNumero();
            }
        }

        public override double ValorTransadoBruto
        {
            get
            {
                return ValorTransadoNeto;
            }
        }
    }
}
