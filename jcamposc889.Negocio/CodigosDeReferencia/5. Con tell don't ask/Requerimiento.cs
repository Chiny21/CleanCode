namespace jcamposc889.Negocio.CodigosDeReferencia.ConTellDontAsk
{
    public class Requerimiento
    {
        private string laFechaComoTextoFinal;
        private string numeroDelClienteFinal;
        private string numeroDelSistemaFinal;
        private string numeroConsecutivoFinal;

        public Requerimiento(DatosParaElRequerimiento losDatos)
        {
            laFechaComoTextoFinal = GenereLaFechaComoTexto(losDatos);
            numeroDelClienteFinal = FormateeElNumeroDelClienteFinal(losDatos);
            numeroDelSistemaFinal = FormateeElNumeroDelSistemaFinal(losDatos);
            numeroConsecutivoFinal = FormateeElNumeroConsecutivoFinal(losDatos);
        }

        private string GenereLaFechaComoTexto(DatosParaElRequerimiento losDatos)
        {
            return new Fecha(losDatos).ComoTexto();
        }

        private string FormateeElNumeroDelClienteFinal(DatosParaElRequerimiento losDatos)
        {
            return losDatos.NumeroDelClienteFormateado;
        }

        private string FormateeElNumeroDelSistemaFinal(DatosParaElRequerimiento losDatos)
        {
            return losDatos.NumeroDelSistemaFormateado;
        }

        private string FormateeElNumeroConsecutivoFinal(DatosParaElRequerimiento losDatos)
        {
            return losDatos.NumeroConsecutivoFormateado;
        }

        public string ComoTexto()
        {
            return laFechaComoTextoFinal + numeroDelClienteFinal + numeroDelSistemaFinal 
                + numeroConsecutivoFinal;
        }
    }
}
