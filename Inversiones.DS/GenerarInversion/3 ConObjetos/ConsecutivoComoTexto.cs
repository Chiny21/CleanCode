using System;
using Inversiones.DS.MapeoABaseDeDatos;

namespace Inversiones.DS.GenerarInversion.ConObjetos
{
    class ConsecutivoComoTexto
    {
        private int elConsecutivo;

        public ConsecutivoComoTexto(DateTime laFechaActual)
        {
           elConsecutivo = ObtengaElConsecutivo(laFechaActual);
        }

        private int ObtengaElConsecutivo(DateTime laFechaActual)
        {
            return new RepositorioDeParametros().ObtengaElConsecutivoParaElCodigoDeReferencia(laFechaActual);
        }

        public string ComoTexto()
        {
            return elConsecutivo.ToString();
        }
    }
}
