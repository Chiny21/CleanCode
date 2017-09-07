using System;

namespace jcamposc889.Negocio.CodigosDeReferencia.ConObjetos
{
    public class DiaComoTexto
    {
        private string elDiaComoTexto;

        public DiaComoTexto(DateTime laFecha)
        {
            elDiaComoTexto = GenereElDiaComoTexto(laFecha);
        }

        private static string GenereElDiaComoTexto(DateTime laFecha)
        {
            return new Dia(laFecha).ComoTexto();
        }

        public string Formateado()
        {
            return FormateeElDiaFinal(elDiaComoTexto);
        }

        private static string FormateeElDiaFinal(string elDiaComoTexto)
        {
            return elDiaComoTexto.PadLeft(2, '0');
        }
    }
}
