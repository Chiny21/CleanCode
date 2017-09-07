using System;

namespace jcamposc889.Negocio.CodigosDeReferencia.ComoUnProcedimiento
{
    public static class CalculosDeCodigosDeReferencia
    {
        public static string GenereElCodigoDeReferencia(DateTime laFecha, 
            string numeroDelCliente, string numeroDelSistema, string numeroConsecutivo)
        {
            int elAno = laFecha.Year;
            string elAnoComoTextoFinal = elAno.ToString();
            
            int elMes = laFecha.Month;
            string elMesComoTexto = elMes.ToString();
            string elMesComoTextoFinal = elMesComoTexto.PadLeft(2, '0');

            int elDia = laFecha.Day;
            string elDiaComoTexto = elDia.ToString();
            string elDiaComoTextoFinal = elDiaComoTexto.PadLeft(2, '0');

            string laFechaComoTextoFinal = elAnoComoTextoFinal + elMesComoTextoFinal 
                + elDiaComoTextoFinal;

            string numeroDelClienteFinal = numeroDelCliente.PadLeft(3, '0');
            string numeroDelSistemaFinal = numeroDelSistema.PadLeft(2, '0');
            string numeroConsecutivoFinal = numeroConsecutivo.PadLeft(12, '0');

            string elRequerimiento = laFechaComoTextoFinal + numeroDelClienteFinal 
                + numeroDelSistemaFinal + numeroConsecutivoFinal;

            int elDigitoVerificador = CalculeElDigitoVerificador(elRequerimiento);
            string elDigitoVerificadorComoTexto = elDigitoVerificador.ToString();

            return elRequerimiento + elDigitoVerificadorComoTexto;
        }

        private static int CalculeElDigitoVerificador(string elRequerimiento)
        {
            const string laHileraDePesos = "1234567891234567891234567";

            int elInicioDelPeso = 0;
            elInicioDelPeso = laHileraDePesos.Length - elRequerimiento.Length;

            int laSumaDePesos = 0;
            short laPosicionActual = 0;
            for (laPosicionActual = 0; laPosicionActual <= elRequerimiento.Length - 1; laPosicionActual++)
            {
                int elPesoActual = short.Parse(elRequerimiento.Substring(laPosicionActual, 1)) *
                    short.Parse(laHileraDePesos.Substring(elInicioDelPeso + laPosicionActual, 1));
                laSumaDePesos = laSumaDePesos + elPesoActual;
            }

            int elResiduo = laSumaDePesos % 11;

            int elDigito;
            if (elResiduo == 10)
                elDigito = 1;
            else
                elDigito = elResiduo;

            return elDigito;
        }
    }
}
