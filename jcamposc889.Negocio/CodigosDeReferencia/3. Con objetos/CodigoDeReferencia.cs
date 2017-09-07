using System;

namespace jcamposc889.Negocio.CodigosDeReferencia.ConObjetos
{
    public class CodigoDeReferencia
    {
        private string elRequerimiento;
        private string elDigitoVerificadorComoTexto;

        public CodigoDeReferencia(DateTime laFecha, string numeroDelCliente, 
            string numeroDelSistema, string numeroConsecutivo)
        {
            elRequerimiento = GenereElRequerimiento(laFecha,
                numeroDelCliente, numeroDelSistema, numeroConsecutivo);

            elDigitoVerificadorComoTexto = 
                GenereElDigitoVerificadorComoTexto(elRequerimiento);
        }

        private static string GenereElRequerimiento(DateTime laFecha,
            string numeroDelCliente, string numeroDelSistema, string numeroConsecutivo)
        {
            return new Requerimiento(laFecha, numeroDelCliente, numeroDelSistema, 
                numeroConsecutivo).ComoTexto();           
        }

        private static string GenereElDigitoVerificadorComoTexto(string elRequerimiento)
        {
            return new DigitoVerificador(elRequerimiento).ComoTexto();
        }

        public string ComoTexto()
        {
            return GenereElCodigoDeReferencia(elRequerimiento, elDigitoVerificadorComoTexto);
        }

        private static string GenereElCodigoDeReferencia(string elRequerimiento,
            string elDigitoVerificadorComoTexto)
        {
            return elRequerimiento + elDigitoVerificadorComoTexto;
        }
    }
}
