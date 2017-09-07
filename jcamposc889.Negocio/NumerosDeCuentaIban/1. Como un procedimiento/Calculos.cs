using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jcamposc889.Negocio.IbanNacional.ComoUnProcedimiento
{
    public static class CalculosDeCuentasIban
    {
        public static string GenereElNumeroDeCuentaIban(string laCuentaCliente)
        {
            const string lasLetrasDelPais = "1227";
            const string elCodigoDelPais = "00";
            string elRequerimiento;
            elRequerimiento = laCuentaCliente + lasLetrasDelPais + elCodigoDelPais;

            decimal elRequerimientoComoNumero = decimal.Parse(elRequerimiento);

            decimal elNumeroVerificador = 98 - (elRequerimientoComoNumero % 97);

            string losDosDigitosVerificadores;
            if (elNumeroVerificador < 10)
                losDosDigitosVerificadores = "0" + elNumeroVerificador;
            else
                losDosDigitosVerificadores = elNumeroVerificador.ToString();

            return "CR" + losDosDigitosVerificadores + laCuentaCliente;
        }
    }
}
