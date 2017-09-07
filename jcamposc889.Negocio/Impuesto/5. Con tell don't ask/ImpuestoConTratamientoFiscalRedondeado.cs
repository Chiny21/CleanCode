using System;
using jcamposc889.Negocio.RendimientoPorDescuento.ConTellDontAsk;

namespace jcamposc889.Negocio.Impuesto.ConTellDontAsk
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
