namespace jcamposc889.Negocio.CodigosDeReferencia.ConParameterObject
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
            // TODO: NO CUMPLE CON LA LEY DE DEMETER
            return losDatos.NumeroDelCliente.PadLeft(3, '0');
        }

        private string FormateeElNumeroDelSistemaFinal(DatosParaElRequerimiento losDatos)
        {
            // TODO: NO CUMPLE CON LA LEY DE DEMETER
            return losDatos.NumeroDelSistema.PadLeft(2, '0');
        }

        private string FormateeElNumeroConsecutivoFinal(DatosParaElRequerimiento losDatos)
        {
            // TODO: NO CUMPLE CON LA LEY DE DEMETER
            return losDatos.NumeroConsecutivo.PadLeft(12, '0');
        }

        public string ComoTexto()
        {
            return laFechaComoTextoFinal + numeroDelClienteFinal + numeroDelSistemaFinal 
                + numeroConsecutivoFinal;
        }
    }
}
