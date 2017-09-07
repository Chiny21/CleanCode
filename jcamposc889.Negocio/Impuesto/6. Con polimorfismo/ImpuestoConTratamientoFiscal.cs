using jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo;

namespace jcamposc889.Negocio.Impuesto.ConPolimorfismo
{
    public class ImpuestoConTratamientoFiscal
    {
        private double elValorTransadoNeto;
        private double elValorTransadoBruto;

        public ImpuestoConTratamientoFiscal(DatosDeInversion losDatos)
        {
            elValorTransadoNeto = ExtraigaElValorTransadoNeto(losDatos);
            elValorTransadoBruto = GenereElValorTransadoBruto(losDatos);
        }

        private double ExtraigaElValorTransadoNeto(DatosDeInversion losDatos)
        {
            return losDatos.ValorTransadoNeto;
        }

        private double GenereElValorTransadoBruto(DatosDeInversion losDatos)
        {
            return new ValorTransadoBrutoConTratamientoFiscal(losDatos).ComoNumero();
        }

        public double Calculado()
        {
            return elValorTransadoNeto - elValorTransadoBruto;
        }
    }
}
