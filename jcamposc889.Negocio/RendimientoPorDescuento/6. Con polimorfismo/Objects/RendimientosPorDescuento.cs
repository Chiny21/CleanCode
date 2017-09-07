namespace jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo
{
    public class RendimientosPorDescuento
    {
        private double elValorTransadoBruto;
        private double elValorFacial;

        public RendimientosPorDescuento(DatosDeInversion losDatos)
        {
            elValorTransadoBruto = GenereElValorTransadoBruto(losDatos);
            elValorFacial = ObtengaElValorFacial(losDatos);
        }

        private double GenereElValorTransadoBruto(DatosDeInversion losDatos)
        {
            return losDatos.ValorTransadoBruto;
        }

        private double ObtengaElValorFacial(DatosDeInversion losDatos)
        {
            return losDatos.ValorFacial;
        }

        public double ComoNumero()
        {
            return elValorFacial - elValorTransadoBruto;
        }
    }
}
