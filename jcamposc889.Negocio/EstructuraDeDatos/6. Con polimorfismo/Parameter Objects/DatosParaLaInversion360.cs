namespace jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo
{
    public class DatosParaLaInversion360 : DatosParaLaInversion
    {
        public override double ImpuestoPagado
        {
            get
            {
                return new ImpuestoPagado360(this).ComoNumero();
            }
        }

        public override double RendimientoPorDescuento
        {
            get
            {
                return new RendimientoPorDescuento360(this).ComoNumero();
            }
        }

        public override double TasaBruta
        {
            get
            {
                return new TasaBruta360(this).ComoNumero();
            }
        }

        public override double TasaNeta
        {
            get
            {
                return new TasaNeta360(this).ComoNumero();
            }
        }

        public override double ValorTransadoBruto
        {
            get
            {
                return new ValorTransadoBruto360(this).ComoNumero();
            }
        }
    }
}
