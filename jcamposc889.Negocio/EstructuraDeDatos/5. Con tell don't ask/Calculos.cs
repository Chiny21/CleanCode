namespace jcamposc889.Negocio.EstructuraDeDatos.ConTellDontAsk
{
    public static class Calculos
    {
        public static Inversion GenereUnaNuevaInversion(DatosParaLaInversion losDatos)
        {
            Inversion laNuevaInversion = new Inversion();

            laNuevaInversion.CodigoDeReferencia = GenereElCodigoDeReferencia(losDatos);
            laNuevaInversion.TasaNeta = losDatos.TasaNeta;
            laNuevaInversion.TasaBruta = losDatos.TasaBruta;
            laNuevaInversion.ValorTransadoBruto = losDatos.ValorTransadoBruto;
            laNuevaInversion.ImpuestoPagado = losDatos.ImpuestoPagado;
            laNuevaInversion.RendimientoPorDescuento = losDatos.RendimientoPorDescuento;
            laNuevaInversion.FechaDeValor = losDatos.FechaActual;
            laNuevaInversion.FechaDeVencimiento = losDatos.FechaDeVencimiento;

            return laNuevaInversion;
        }

        private static string GenereElCodigoDeReferencia(DatosParaLaInversion losDatos)
        {
            return new CodigoDeReferenciaParaInversion(losDatos).ComoTexto();
        }
    }
}
