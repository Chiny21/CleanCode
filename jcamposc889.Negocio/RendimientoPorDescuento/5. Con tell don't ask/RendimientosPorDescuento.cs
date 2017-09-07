namespace jcamposc889.Negocio.RendimientoPorDescuento.ConTellDontAsk
{
    public class RendimientosPorDescuento
    {
        private double elValorTransadoBruto;
        private double elValorFacial;

        public RendimientosPorDescuento(DatosParaElRendimientoPorDescuento losDatos)
        {
            elValorTransadoBruto = GenereElValorTransadoBruto(losDatos);
            elValorFacial = ObtengaElValorFacial(losDatos);
        }

        private double GenereElValorTransadoBruto(DatosParaElRendimientoPorDescuento losDatos)
        {
            return losDatos.ValorTransadoBruto;
        }

        private double ObtengaElValorFacial(DatosParaElRendimientoPorDescuento losDatos)
        {
            return losDatos.ValorFacial;
        }

        public double ComoNumero()
        {
            return elValorFacial - elValorTransadoBruto;
        }
    }
}
