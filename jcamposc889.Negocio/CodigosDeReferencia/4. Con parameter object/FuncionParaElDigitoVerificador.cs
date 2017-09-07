namespace jcamposc889.Negocio.CodigosDeReferencia.ConParameterObject
{
    public static class FuncionParaElDigitoVerificador
    {
        public static int CalculeElDigitoVerificador(string elRequerimiento)
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
