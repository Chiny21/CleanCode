using System;

namespace jcamposc889.Negocio.RendimientoPorDescuento.ConObjetos
{
    public class DiasAlVencimiento
    {
        private TimeSpan losDiasAlVencimiento;

        public DiasAlVencimiento(DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            losDiasAlVencimiento = CalculeLosDiasAlVencimiento(laFechaDeVencimiento,
                laFechaActual);
        }

        private TimeSpan CalculeLosDiasAlVencimiento(DateTime laFechaDeVencimiento,
            DateTime laFechaActual)
        {
            return laFechaDeVencimiento - laFechaActual;
        }

        public double ComoNumero()
        {
            return losDiasAlVencimiento.Days;
        }
    }
}
