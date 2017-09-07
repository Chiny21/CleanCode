namespace jcamposc889.Negocio.IbanNacional.ConFunciones
{
    public static class CalculosDeCuentasIban
    {
        public static string GenereElNumeroDeCuentaIban(string laCuentaCliente)
        {
            string losDosDigitosVerificadores;
            losDosDigitosVerificadores = ObtengaLosDigitosVerificadores(laCuentaCliente);

            return FormateeElNumeroDeCuenta(laCuentaCliente, losDosDigitosVerificadores);
        }

        private static string ObtengaLosDigitosVerificadores(string laCuentaCliente)
        {
            decimal elNumeroVerificador;
            elNumeroVerificador = ObtengaElNumeroVerificadorComoDecimal(laCuentaCliente);

            return FormateeADosDigitos(elNumeroVerificador);
        }

        private static decimal ObtengaElNumeroVerificadorComoDecimal(string laCuentaCliente)
        {
            decimal elRequerimientoComoNumero = ObtengaElNumeroVerificador(laCuentaCliente);

            return ObtengaComoDecimal(elRequerimientoComoNumero);
        }

        private static decimal ObtengaElNumeroVerificador(string laCuentaCliente)
        {
            string elRequerimiento;
            elRequerimiento = ObtengaElRequerimientoComoNumero(laCuentaCliente);

            return CalculeElNumeroVerificador(elRequerimiento);
        }

        private static string ObtengaElRequerimientoComoNumero(string laCuentaCliente)
        {
            const string lasLetrasDelPais = "1227";
            const string elCodigoDelPais = "00";
            return laCuentaCliente + lasLetrasDelPais + elCodigoDelPais;
        }

        private static decimal CalculeElNumeroVerificador(string elRequerimiento)
        {
            return decimal.Parse(elRequerimiento);
        }

        private static decimal ObtengaComoDecimal(decimal elRequerimientoComoNumero)
        {
            return 98 - (elRequerimientoComoNumero % 97);
        }

        private static string FormateeADosDigitos(decimal elNumeroVerificador)
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

        private static string FormateeElNumeroDeCuenta(string laCuentaCliente, string losDosDigitosVerificadores)
        {
            return "CR" + losDosDigitosVerificadores + laCuentaCliente;
        }
    }
}
