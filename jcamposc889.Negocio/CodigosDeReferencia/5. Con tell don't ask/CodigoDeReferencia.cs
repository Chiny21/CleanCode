namespace jcamposc889.Negocio.CodigosDeReferencia.ConTellDontAsk
{
    public class CodigoDeReferencia
    {
        private string elRequerimiento;
        private string elDigitoVerificadorComoTexto;

        public CodigoDeReferencia(DatosParaElRequerimiento losDatos)
        {
            elRequerimiento = GenereElRequerimiento(losDatos);
            elDigitoVerificadorComoTexto = GenereElDigitoVerificadorComoTexto();
        }

        private string GenereElRequerimiento(DatosParaElRequerimiento losDatos)
        {
            return new Requerimiento(losDatos).ComoTexto();           
        }

        private string GenereElDigitoVerificadorComoTexto()
        {
            return new DigitoVerificador(elRequerimiento).ComoTexto();
        }

        public string ComoTexto()
        {
            return elRequerimiento + elDigitoVerificadorComoTexto;
        }
    }
}
