using jcamposc889.Negocio.RendimientoPorDescuento.ConParameterObject;

namespace jcamposc889.Negocio.Impuesto.ConParameterObject
{
    public class ImpuestoConTratamientoFiscal
    {
        private double elValorTransadoNeto;
        private double elValorTransadoBruto;

        public ImpuestoConTratamientoFiscal(DatosParaElRendimientoPorDescuento losDatos)
        {
            // TODO: ARREGLAR ESTOS DETALLES
            elValorTransadoNeto = losDatos.ValorTransadoNeto;
            elValorTransadoBruto = GenereElValorTransadoBruto(losDatos);
        }

        private double GenereElValorTransadoBruto(DatosParaElRendimientoPorDescuento losDatos)
        {
            return new ValorTransadoBrutoConTratamientoFiscal(losDatos).ComoNumero();
        }

        public double Calculado()
        {
            return elValorTransadoNeto - elValorTransadoBruto;
        }
    }
}
