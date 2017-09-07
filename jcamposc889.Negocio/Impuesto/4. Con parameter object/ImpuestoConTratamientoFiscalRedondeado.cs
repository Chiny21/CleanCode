using System;
using jcamposc889.Negocio.RendimientoPorDescuento.ConParameterObject;

namespace jcamposc889.Negocio.Impuesto.ConParameterObject
{
    public class ImpuestoConTratamientoFiscalRedondeado
    {
        private double elImpuestoConTratamientoFiscal;

        public ImpuestoConTratamientoFiscalRedondeado(DatosParaElRendimientoPorDescuento losDatos)
        {
            elImpuestoConTratamientoFiscal = new ImpuestoConTratamientoFiscal(losDatos).Calculado();
        }

        public double Redondeado()
        {
            return Math.Round(elImpuestoConTratamientoFiscal, 4);
        }
    }
}
