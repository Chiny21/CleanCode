using System;
using Inversiones.DS.MapeoABaseDeDatos;

namespace Inversiones.DS.GenerarInversion.ConPolimorfismo
{
    public class ConsecutivoComoTexto
    {
        private int elConsecutivo;

        public ConsecutivoComoTexto(DatosParaLaFecha losDatosParaLaFecha)
        {
           elConsecutivo = losDatosParaLaFecha.Consecutivo;
        }

        public string ComoTexto()
        {
            return elConsecutivo.ToString();
        }
    }
}
