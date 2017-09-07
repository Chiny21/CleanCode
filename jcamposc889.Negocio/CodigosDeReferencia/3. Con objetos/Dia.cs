using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jcamposc889.Negocio.CodigosDeReferencia.ConObjetos
{
    public class Dia
    {
        private int elDia;

        public Dia(DateTime laFecha)
        {
            elDia = ExtraigaElDiaDeLaFecha(laFecha);
        }

        private int ExtraigaElDiaDeLaFecha(DateTime laFecha)
        {
            return laFecha.Day;
        }

        public string ComoTexto()
        {
            return FormateeElDiaComoTexto(elDia);
        }

        private static string FormateeElDiaComoTexto(int elDia)
        {
            return elDia.ToString();
        }
    }
}
