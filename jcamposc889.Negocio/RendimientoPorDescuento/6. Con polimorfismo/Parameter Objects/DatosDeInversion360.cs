using jcamposc889.Negocio.Impuesto.ConPolimorfismo;

namespace jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo
{
    public class DatosDeInversion360 : DatosDeInversion
    {
        public override double DiasDelAño
        {
            get
            {
                return 360;
            }
        }

        public override double Impuesto
        {
            get
            {
                return new ImpuestoConTratamientoFiscalRedondeado(this).Redondeado();
            }
        }

        public override double ValorTransadoBruto
        {
            get
            {
                return new ValorTransadoBrutoConTratamientoFiscal(this).ComoNumero();
            }
        }
    }
}
