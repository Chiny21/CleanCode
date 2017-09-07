using jcamposc889.Negocio.RendimientoPorDescuento.ConParameterObject;

namespace jcamposc889.Negocio.Impuesto.ConParameterObject
{
    public static class Impuesto
    {
        public static double CalculeElImpuesto(DatosParaElRendimientoPorDescuento losDatos)
        {
            // TODO: HAY MAS DE UNA OPERACION
            if (losDatos.tieneTratamientoFiscal)
            {
                return GenereElImpuestoConTratamientoFiscal(losDatos);
            }
            else
            {
                return GenereElImpuestoSinTratamientoFiscal();
            }
        }

        private static double GenereElImpuestoConTratamientoFiscal(DatosParaElRendimientoPorDescuento losDatos)
        {
            return new ImpuestoConTratamientoFiscalRedondeado(losDatos).Redondeado();
        }

        private static double GenereElImpuestoSinTratamientoFiscal()
        {
            return 0;
        }
    }
}
