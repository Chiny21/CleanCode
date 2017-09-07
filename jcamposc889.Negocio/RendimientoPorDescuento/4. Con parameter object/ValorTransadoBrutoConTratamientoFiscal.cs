namespace jcamposc889.Negocio.RendimientoPorDescuento.ConParameterObject
{
    public class ValorTransadoBrutoConTratamientoFiscal
    {
        private DatosParaLaTasaBruta losDatosParaLaTasaBruta;
        private double laTasaBruta;

        public ValorTransadoBrutoConTratamientoFiscal(DatosParaElRendimientoPorDescuento losDatos)
        {
            losDatosParaLaTasaBruta = new DatosParaLaTasaBruta();
            // TODO: ARREGLAR ESTOS DETALLES
            losDatosParaLaTasaBruta.ValorFacial = losDatos.ValorFacial;
            losDatosParaLaTasaBruta.ValorTransadoNeto = losDatos.ValorTransadoNeto;
            losDatosParaLaTasaBruta.TasaDeImpuesto = losDatos.TasaDeImpuesto;
            losDatosParaLaTasaBruta.DiasAlVencimientoComoNumero = GenereLosDiasAlVencimiento(losDatos);
            laTasaBruta = GenereLaTasaBruta(losDatosParaLaTasaBruta);
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
            // TODO: HAY MAS DE UNA OPERACION
            return losDatosParaLaTasaBruta.ValorFacial / (1 + (laTasaBruta / 100) * 
                (losDatosParaLaTasaBruta.DiasAlVencimientoComoNumero / 365));
        }
    }
}
