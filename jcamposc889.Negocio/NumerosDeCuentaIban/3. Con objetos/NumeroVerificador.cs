namespace jcamposc889.Negocio.IbanNacional.ConObjetos
{
    public class NumeroVerificador
    {
        decimal elRequerimientoComoNumero;

        public NumeroVerificador(string laCuentaCliente)
        {
            elRequerimientoComoNumero = new Requerimiento(laCuentaCliente).ComoNumero();
        }

        public decimal ComoNumero()
        {
            return 98 - (elRequerimientoComoNumero % 97);
        }
    }
}
