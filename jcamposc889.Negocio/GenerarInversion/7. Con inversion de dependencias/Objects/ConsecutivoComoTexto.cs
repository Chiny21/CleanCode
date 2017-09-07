﻿namespace Inversiones.Negocio.GenerarInversion.ConInversionDeDependencias
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
