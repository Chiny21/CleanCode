namespace jcamposc889.Negocio.RendimientoPorDescuento.ConTellDontAsk
{
    public class ValorTransadoBrutoConTratamientoFiscal
    {
        private double elValorFacial;
        private double losDiasAlVencimientoComoNumero;
        private double laTasaBruta;

        public ValorTransadoBrutoConTratamientoFiscal(DatosParaElRendimientoPorDescuento losDatos)
        {
            elValorFacial = losDatos.ValorFacial;
            losDiasAlVencimientoComoNumero = GenereLosDiasAlVencimiento(losDatos);

            DatosParaLaTasaBruta losDatosParaLaTasaBruta = new DatosParaLaTasaBruta();
            losDatosParaLaTasaBruta.elValorFacial = ExtraigaElValorFacial(losDatos);
            losDatosParaLaTasaBruta.elValorTransadoNeto = ExtraigaElValorTransadoNeto(losDatos);
            losDatosParaLaTasaBruta.laTasaDeImpuesto = ExtraigaLaTasaDeImpuesto(losDatos);
            losDatosParaLaTasaBruta.losDiasAlVencimientoComoNumero = losDiasAlVencimientoComoNumero;

            laTasaBruta = GenereLaTasaBruta(losDatosParaLaTasaBruta);
        }

        private double ExtraigaElValorFacial(DatosParaElRendimientoPorDescuento losDatos)
        {
            return losDatos.ValorFacial;
        }

        private double ExtraigaElValorTransadoNeto(DatosParaElRendimientoPorDescuento losDatos)
        {
            return losDatos.ValorTransadoNeto;
        }

        private double ExtraigaLaTasaDeImpuesto(DatosParaElRendimientoPorDescuento losDatos)
        {
            return losDatos.TasaDeImpuesto;
        }

        private double GenereLosDiasAlVencimiento(DatosParaElRendimientoPorDescuento losDatos)
        {
            return new DiasAlVencimiento(losDatos).ComoNumero();
        }

        private double GenereLaTasaBruta(DatosParaLaTasaBruta losDatosParaLaTasaBruta)
        {
            return new TasaBruta(losDatosParaLaTasaBruta).Calculado();
        }

        public double ComoNumero()
        {
            return elValorFacial / (1 + (laTasaBruta / 100) * 
                (losDiasAlVencimientoComoNumero / 365));
        }
    }
}
