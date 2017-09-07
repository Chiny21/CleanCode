using System;

namespace jcamposc889.Negocio.RendimientoPorDescuento.ConParameterObject
{
    public class DiasAlVencimiento
    {
        private TimeSpan losDiasAlVencimiento;

        public DiasAlVencimiento(DatosParaElRendimientoPorDescuento losDatos)
        {
            // TODO: HAY MAS DE UNA OPERACION
            losDiasAlVencimiento = losDatos.FechaDeVencimiento - losDatos.FechaActual;
        }

        public double ComoNumero()
        {
            return losDiasAlVencimiento.Days;
        }
    }
}
