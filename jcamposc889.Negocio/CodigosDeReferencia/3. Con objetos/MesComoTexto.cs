using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jcamposc889.Negocio.CodigosDeReferencia.ConObjetos
{
    public class MesComoTexto
    {
        private string elMesComoTexto;

        public MesComoTexto(DateTime laFecha)
        {
            elMesComoTexto = GenereElMesComoTexto(laFecha);
        }

        private string GenereElMesComoTexto(DateTime laFecha)
        {
            return new Mes(laFecha).ComoTexto();
        }

        public string Formateado()
        {
            return FormateeElMesFinal(elMesComoTexto);
        }

        private string FormateeElMesFinal(string elMesComoTexto)
        {
            return elMesComoTexto.PadLeft(2, '0');
        }
    }
}
