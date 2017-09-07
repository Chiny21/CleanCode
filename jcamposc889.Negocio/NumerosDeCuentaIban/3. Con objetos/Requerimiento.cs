namespace jcamposc889.Negocio.IbanNacional.ConObjetos
{
    public class Requerimiento
    {
        string elRequerimiento;

        public Requerimiento(string laCuentaCliente)
        {
            const string lasLetrasDelPais = "1227";
            const string elCodigoDelPais = "00";
            elRequerimiento = laCuentaCliente + lasLetrasDelPais + elCodigoDelPais;
        }

        public decimal ComoNumero()
        {
            return decimal.Parse(elRequerimiento);
        }
    }
}
