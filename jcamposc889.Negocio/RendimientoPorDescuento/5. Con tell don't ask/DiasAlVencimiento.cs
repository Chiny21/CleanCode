using System;

namespace jcamposc889.Negocio.RendimientoPorDescuento.ConTellDontAsk
{
    public class DiasAlVencimiento
    {
        private TimeSpan losDiasAlVencimiento;

        public DiasAlVencimiento(DatosParaElRendimientoPorDescuento losDatos)
        {
            losDiasAlVencimiento = losDatos.DiferenciaEntreLasFechas;
        }

        public double ComoNumero()
        {
            return losDiasAlVencimiento.Days;
        }
    }
}
