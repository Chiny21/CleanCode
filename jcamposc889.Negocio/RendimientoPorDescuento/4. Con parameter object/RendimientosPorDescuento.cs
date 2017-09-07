namespace jcamposc889.Negocio.RendimientoPorDescuento.ConParameterObject
{
    public class RendimientosPorDescuento
    {
        private double elValorTransadoBruto;
        private double elValorFacial;

        public RendimientosPorDescuento(DatosParaElRendimientoPorDescuento losDatos)
        {
            elValorTransadoBruto = GenereElValorTransadoBruto(losDatos);
            //TODO: ARREGLAR ESTE DETALLE
            elValorFacial = losDatos.ValorFacial;
        }

        private double GenereElValorTransadoBruto(DatosParaElRendimientoPorDescuento losDatos)
        {
            if (losDatos.tieneTratamientoFiscal)
            {
                return ObtengaElValorTransadoBrutoConTratamientoFiscal(losDatos);
            }
            else
            {
                return ObtengaElValorTransadoBrutoSinTratamientoFiscal(losDatos);
            }
        }

        private double ObtengaElValorTransadoBrutoConTratamientoFiscal(DatosParaElRendimientoPorDescuento losDatos)
        {
            return new ValorTransadoBrutoConTratamientoFiscal(losDatos).ComoNumero();
        }

        private double ObtengaElValorTransadoBrutoSinTratamientoFiscal(DatosParaElRendimientoPorDescuento losDatos)
        {
            return losDatos.ValorTransadoNeto;
        }

        public double ComoNumero()
        {
            return elValorFacial - elValorTransadoBruto;
        }
    }
}
