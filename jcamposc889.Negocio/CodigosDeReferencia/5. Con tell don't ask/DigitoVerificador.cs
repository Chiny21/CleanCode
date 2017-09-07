namespace jcamposc889.Negocio.CodigosDeReferencia.ConTellDontAsk
{
    public class DigitoVerificador
    {
        private int elDigito;

        public DigitoVerificador(string elRequerimiento)
        {
            elDigito = FuncionParaElDigitoVerificador.Calcule(elRequerimiento);
        }

        public string ComoTexto()
        {
            return elDigito.ToString();
        }
    }
}
