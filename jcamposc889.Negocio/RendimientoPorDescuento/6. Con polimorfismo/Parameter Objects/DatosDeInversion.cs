using System;

namespace jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo
{
    public abstract class DatosDeInversion : DatosBaseDeInversion
    {
        public double DiasAlVencimientoComoNumero
        {
            get
            {
                return new DiasAlVencimiento(this).ComoNumero();
            }
        }

        public double TasaNeta
        {
            get
            {
                return ((ValorFacial - ValorTransadoNeto) / (ValorTransadoNeto *
                    (DiasAlVencimientoComoNumero / DiasDelAño))) * 100;
            }
        }

        public abstract double ValorTransadoBruto { get; }

        public abstract double Impuesto { get; }

        public abstract double DiasDelAño{ get; }

        public int Año
        {
            get
            {
                return FechaActual.Year;
            }
        }
    }
}

