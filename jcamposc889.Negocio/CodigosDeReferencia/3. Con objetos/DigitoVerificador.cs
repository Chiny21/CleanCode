namespace jcamposc889.Negocio.CodigosDeReferencia.ConObjetos
{
    public class DigitoVerificador
    {
        private int elDigitoVerificador;

        public DigitoVerificador(string elRequerimiento)
        {
            elDigitoVerificador = FuncionParaElDigitoVerificador.CalculeElDigitoVerificador(elRequerimiento);
        }

        public string ComoTexto()
        {
            return FormateeElDigitoVerificadorComoTexto(elDigitoVerificador);
        }

        private string FormateeElDigitoVerificadorComoTexto(int elDigitoVerificador)
        {
            return elDigitoVerificador.ToString();
        }
    }
}
