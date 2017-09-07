using System;

namespace jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo
{
    public class DatosDeInversionSinTratamientoFiscal : DatosDeInversion
    {
        public override double ValorTransadoBruto
        {
            get
            {
                return ValorTransadoNeto;
            }
        }

        public override double Impuesto
        {
            get
            {
                return 0;
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
