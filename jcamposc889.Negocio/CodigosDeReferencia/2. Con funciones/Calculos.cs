using System;

namespace jcamposc889.Negocio.CodigosDeReferencia.ConFunciones
{
    public static class Calculos
    {
        public static string GenereElCodigoDeReferencia(DateTime laFecha,
            string numeroDelCliente, string numeroDelSistema, string numeroConsecutivo)
        {
            string elRequerimiento = GenereElRequerimiento(laFecha,
                numeroDelCliente, numeroDelSistema, numeroConsecutivo);

            string elDigitoVerificadorComoTexto =
                GenereElDigitoVerificadorComoTexto(elRequerimiento);

            return GenereElCodigoDeReferencia(elRequerimiento,
                elDigitoVerificadorComoTexto);
        }

        private static string GenereElRequerimiento(DateTime laFecha,
            string numeroDelCliente, string numeroDelSistema, string numeroConsecutivo)
        {
            string laFechaComoTextoFinal = GenereLaFechaComoTextoFinal(laFecha);

            string numeroDelClienteFinal =
                FormateeElNumeroDelClienteFinal(numeroDelCliente);

            string numeroDelSistemaFinal =
                FormateeElNumeroDelSistemaFinal(numeroDelSistema);

            string numeroConsecutivoFinal =
                FormateeElNumeroConsecutivoFinal(numeroConsecutivo);

            return GenereElRequerimiento(laFechaComoTextoFinal, numeroDelClienteFinal,
                numeroDelSistemaFinal, numeroConsecutivoFinal);
        }

        private static string GenereLaFechaComoTextoFinal(DateTime laFecha)
        {
            string elAñoComoTextoFinal = GenereElAñoComoTextoFinal(laFecha);
            string elMesComoTextoFinal = GenereElMesComoTextoFinal(laFecha);
            string elDiaComoTextoFinal = GenereElDiaComoTextoFinal(laFecha);

            return FormateeLaFechaFinal(elAñoComoTextoFinal, elMesComoTextoFinal,
                elDiaComoTextoFinal);
        }

        private static string GenereElAñoComoTextoFinal(DateTime laFecha)
        {
            int elAño = ExtraigaElAñoDeLaFecha(laFecha);
            return GenereElAñoComoTexto(elAño);
        }

        private static int ExtraigaElAñoDeLaFecha(DateTime laFecha)
        {
            return laFecha.Year;
        }

        private static string GenereElAñoComoTexto(int elAño)
        {
            return elAño.ToString();
        }

        private static string GenereElMesComoTextoFinal(DateTime laFecha)
        {
            string elMesComoTexto = GenereElMesComoTexto(laFecha);
            return FormateeElMesFinal(elMesComoTexto);
        }

        private static string GenereElMesComoTexto(DateTime laFecha)
        {
            int elMes = ExtraigaElMesDeLaFecha(laFecha);
            return FormateeElMesComoTexto(elMes);
        }

        private static int ExtraigaElMesDeLaFecha(DateTime laFecha)
        {
            return laFecha.Month;
        }

        private static string FormateeElMesComoTexto(int elMes)
        {
            return elMes.ToString();
        }

        private static string FormateeElMesFinal(string elMesComoTexto)
        {
            return elMesComoTexto.PadLeft(2, '0');
        }

        private static string GenereElDiaComoTextoFinal(DateTime laFecha)
        {
            string elDiaComoTexto = GenereElDiaComoTexto(laFecha);
            return FormateeElDiaFinal(elDiaComoTexto);
        }

        private static string GenereElDiaComoTexto(DateTime laFecha)
        {
            int elDia = ExtraigaElDiaDeLaFecha(laFecha);
            return FormateeElDiaComoTexto(elDia);
        }

        private static int ExtraigaElDiaDeLaFecha(DateTime laFecha)
        {
            return laFecha.Day;
        }

        private static string FormateeElDiaComoTexto(int elDia)
        {
            return elDia.ToString();
        }

        private static string FormateeElDiaFinal(string elDiaComoTexto)
        {
            return elDiaComoTexto.PadLeft(2, '0');
        }

        private static string FormateeLaFechaFinal(string elAñoComoTextoFinal, 
            string elMesComoTextoFinal, string elDiaComoTextoFinal)
        {
            return elAñoComoTextoFinal + elMesComoTextoFinal + elDiaComoTextoFinal;
        }

        private static string FormateeElNumeroDelClienteFinal(string numeroDelCliente)
        {
            return numeroDelCliente.PadLeft(3, '0');
        }

        private static string FormateeElNumeroDelSistemaFinal(string numeroDelSistema)
        {
            return numeroDelSistema.PadLeft(2, '0');
        }

        private static string FormateeElNumeroConsecutivoFinal(string numeroConsecutivo)
        {
            return numeroConsecutivo.PadLeft(12, '0');
        }

        private static string GenereElRequerimiento(string laFechaComoTextoFinal, 
            string numeroDelClienteFinal, string numeroDelSistemaFinal, 
            string numeroConsecutivoFinal)
        {
            return laFechaComoTextoFinal + numeroDelClienteFinal + numeroDelSistemaFinal
                            + numeroConsecutivoFinal;
        }

        private static string GenereElDigitoVerificadorComoTexto(string elRequerimiento)
        {
            int elDigitoVerificador = CalculeElDigitoVerificador(elRequerimiento);

            return FormateeElDigitoVerificadorComoTexto(elDigitoVerificador);
        }

        private static string FormateeElDigitoVerificadorComoTexto(int elDigitoVerificador)
        {
            return elDigitoVerificador.ToString();
        }

        private static string GenereElCodigoDeReferencia(string elRequerimiento, 
            string elDigitoVerificadorComoTexto)
        {
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
