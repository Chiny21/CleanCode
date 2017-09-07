using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jcamposc889.Negocio.CodigosDeReferencia.ConObjetos
{
    public class Requerimiento
    {
        private string laFechaComoTextoFinal;
        private string numeroDelClienteFinal;
        private string numeroDelSistemaFinal;
        private string numeroConsecutivoFinal;

        public Requerimiento(DateTime laFecha, string numeroDelCliente, 
            string numeroDelSistema, string numeroConsecutivo)
        {
            laFechaComoTextoFinal = GenereLaFechaComoTexto(laFecha);
            numeroDelClienteFinal = FormateeElNumeroDelClienteFinal(numeroDelCliente);
            numeroDelSistemaFinal = FormateeElNumeroDelSistemaFinal(numeroDelSistema);
            numeroConsecutivoFinal = FormateeElNumeroConsecutivoFinal(numeroConsecutivo);
        }

        private string GenereLaFechaComoTexto(DateTime laFecha)
        {
            return new Fecha(laFecha).ComoTexto();
        }

        private string FormateeElNumeroDelClienteFinal(string numeroDelCliente)
        {
            return numeroDelCliente.PadLeft(3, '0');
        }

        private string FormateeElNumeroDelSistemaFinal(string numeroDelSistema)
        {
            return numeroDelSistema.PadLeft(2, '0');
        }

        private string FormateeElNumeroConsecutivoFinal(string numeroConsecutivo)
        {
            return numeroConsecutivo.PadLeft(12, '0');
        }

        public string ComoTexto()
        {
            return GenereElRequerimiento(laFechaComoTextoFinal, numeroDelClienteFinal,
               numeroDelSistemaFinal, numeroConsecutivoFinal);
        }

        private string GenereElRequerimiento(string laFechaComoTextoFinal,
            string numeroDelClienteFinal, string numeroDelSistemaFinal,
            string numeroConsecutivoFinal)
        {
            return laFechaComoTextoFinal + numeroDelClienteFinal + numeroDelSistemaFinal
                            + numeroConsecutivoFinal;
        }
    }
}
