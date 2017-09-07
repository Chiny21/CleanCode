namespace jcamposc889.Negocio.IbanNacional.ConObjetos
{
    public class NumeroDeCuentaIBAN
    {
        private string laCuentaCliente;
        private string losDosDigitos;

        public NumeroDeCuentaIBAN(string laCuentaCliente)
        {
            this.laCuentaCliente = laCuentaCliente;
            losDosDigitos = new DigitosVerificadores(laCuentaCliente).Formateados();
        }

        public string ComoTexto()
        {
            return "CR" + losDosDigitos + laCuentaCliente;
        }
    }
}
