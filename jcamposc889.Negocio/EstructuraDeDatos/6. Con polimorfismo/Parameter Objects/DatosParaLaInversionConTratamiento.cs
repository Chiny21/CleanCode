namespace jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo
{
    public class DatosParaLaInversionConTratamiento : DatosParaLaInversion
    {
        public override double ImpuestoPagado
        {
            get
            {
                return new ImpuestoPagadoConTratamiento(this).ComoNumero();
            }
        }

        public override double RendimientoPorDescuento
        {
            get
            {
                return new RendimientoPorDescuentoConTratamiento(this).ComoNumero();
            }
        }

        public override double TasaBruta
        {
            get
            {
                return new TasaBrutaConTratamiento(this).ComoNumero();
            }
        }

        public override double TasaNeta
        {
            get
            {
                return new TasaNetaConTratamiento(this).ComoNumero();
            }
        }

        public override double ValorTransadoBruto
        {
            get
            {
                return new ValorTransadoBrutoConTratamiento(this).ComoNumero();
            }
        }
    }
}
