using System;
using jcamposc889.Negocio.Impuesto.ConPolimorfismo;

namespace jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo
{
    public class DatosDeInversionConTratamientoFiscal : DatosDeInversion
    {
        public override double ValorTransadoBruto
        {
            get
            {
                return new ValorTransadoBrutoConTratamientoFiscal(this).ComoNumero();
            }
        }

        public override double Impuesto
        {
            get
            {
                return new ImpuestoConTratamientoFiscalRedondeado(this).Redondeado();
            }
        }

        public override double DiasDelAño
        {
            get
            {
                return new DiasDelAño(this).ComoNumero();
            }
        }
    }
}
