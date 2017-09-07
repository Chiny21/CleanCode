using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jcamposc889.Negocio.CodigosDeReferencia.ConObjetos
{
    public class Mes
    {
        private int elMes;

        public Mes(DateTime laFecha)
        {
            elMes = ExtraigaElMesDeLaFecha(laFecha);
        }

        private int ExtraigaElMesDeLaFecha(DateTime laFecha)
        {
            return laFecha.Month;
        }

        public string ComoTexto()
        {
            return FormateeElMesComoTexto(elMes);
        }

        private string FormateeElMesComoTexto(int elMes)
        {
            return elMes.ToString();
        }
    }
}
