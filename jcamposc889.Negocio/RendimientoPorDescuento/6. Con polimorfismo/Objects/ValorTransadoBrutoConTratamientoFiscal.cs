namespace jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo
{
    public class ValorTransadoBrutoConTratamientoFiscal
    {
        private double elValorFacial;
        private double losDiasAlVencimientoComoNumero;
        private double laTasaBruta;
        private double losDiasDelAño;

        public ValorTransadoBrutoConTratamientoFiscal(DatosDeInversion losDatos)
        {
            elValorFacial = ExtraigaElValorFacial(losDatos);
            losDiasAlVencimientoComoNumero = ExtraigaLosDiasAlVencimiento(losDatos);
            laTasaBruta = GenereLaTasaBruta(losDatos);
            losDiasDelAño = ObtengaLosDiasDelAño(losDatos);
        }

        private double ExtraigaElValorFacial(DatosDeInversion losDatos)
        {
            return losDatos.ValorFacial;
        }

        private double ExtraigaLosDiasAlVencimiento(DatosDeInversion losDatos)
        {
            return losDatos.DiasAlVencimientoComoNumero;
        }

        private double GenereLaTasaBruta(DatosDeInversion losDatos)
        {
            return new TasaBruta(losDatos).Calculado();
        }

        private double ObtengaLosDiasDelAño(DatosDeInversion losDatos)
        {
            return losDatos.DiasDelAño;
        }

        public double ComoNumero()
        {
            return elValorFacial / (1 + (laTasaBruta / 100) *
                (losDiasAlVencimientoComoNumero / losDiasDelAño));
        }
    }
}