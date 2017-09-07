using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jcamposc889.Negocio.CodigosDeReferencia.ConObjetos
{
    public class Fecha
    {
        private string elAñoComoTextoFinal;
        private string elMesComoTextoFinal;
        private string elDiaComoTextoFinal;

        public Fecha(DateTime laFecha)
        {
            elAñoComoTextoFinal = GenereElAñoComoTexto(laFecha);
            elMesComoTextoFinal = GenereElMesComoTextoFormateado(laFecha);
            elDiaComoTextoFinal = GenereElDiaComoTextoFormateado(laFecha);
        }

        private string GenereElAñoComoTexto(DateTime laFecha)
        {
            return new Año(laFecha).ComoTexto();
        }

        private string GenereElMesComoTextoFormateado(DateTime laFecha)
        {
            return new MesComoTexto(laFecha).Formateado();
        }

        private string GenereElDiaComoTextoFormateado(DateTime laFecha)
        {
            return new DiaComoTexto(laFecha).Formateado();
        }

        public string ComoTexto()
        {
            return FormateeLaFechaFinal(elAñoComoTextoFinal, elMesComoTextoFinal,
                elDiaComoTextoFinal);
        }

        private string FormateeLaFechaFinal(string elAñoComoTextoFinal,
            string elMesComoTextoFinal, string elDiaComoTextoFinal)
        {
            return elAñoComoTextoFinal + elMesComoTextoFinal + elDiaComoTextoFinal;
        }
    }
}
