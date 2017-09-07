namespace jcamposc889.Negocio.IbanNacional.ConObjetos
{
    public class DigitosVerificadores
    {
        decimal elNumeroVerificador;

        public DigitosVerificadores(string laCuentaCliente)
        {
            elNumeroVerificador = new NumeroVerificador(laCuentaCliente).ComoNumero();
        }

        public string Formateados()
        {
            if (TieneUnSoloDigito(elNumeroVerificador))
                return FormateePrecedidoConUnCero(elNumeroVerificador);
            else
                return elNumeroVerificador.ToString();
        }

        private static string FormateePrecedidoConUnCero(decimal elNumeroVerificador)
        {
            return "0" + elNumeroVerificador;
        }

        private static bool TieneUnSoloDigito(decimal elNumeroVerificador)
        {
            return elNumeroVerificador < 10;
        }
    }
}