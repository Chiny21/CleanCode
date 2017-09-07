namespace jcamposc889.Negocio.CodigosDeReferencia.ConParameterObject
{
    public class DigitoVerificador
    {
        private int elDigitoVerificador;

        public DigitoVerificador(string elRequerimiento)
        {
            elDigitoVerificador = 
                FuncionParaElDigitoVerificador.CalculeElDigitoVerificador(elRequerimiento);
        }

        public string ComoTexto()
        {
            return elDigitoVerificador.ToString();
        }
    }
}
