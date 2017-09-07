using System;
using jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo;

namespace jcamposc889.Negocio.Impuesto.ConPolimorfismo
{
    public class ImpuestoConTratamientoFiscalRedondeado
    {
        private double elImpuestoConTratamientoFiscal;

        public ImpuestoConTratamientoFiscalRedondeado(DatosDeInversion losDatos)
        {
            elImpuestoConTratamientoFiscal = new ImpuestoConTratamientoFiscal(losDatos).Calculado();
        }

        public double Redondeado()
        {
            return Math.Round(elImpuestoConTratamientoFiscal, 4);
        }
    }
}
