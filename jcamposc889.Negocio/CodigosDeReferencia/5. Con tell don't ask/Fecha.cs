namespace jcamposc889.Negocio.CodigosDeReferencia.ConTellDontAsk
{
    public class Fecha
    {
        private string elAñoComoTextoFinal;
        private string elMesComoTextoFinal;
        private string elDiaComoTextoFinal;

        public Fecha(DatosParaElRequerimiento losDatos)
        {
            elAñoComoTextoFinal = GenereElAñoComoTexto(losDatos);
            elMesComoTextoFinal = GenereElMesComoTextoFormateado(losDatos);
            elDiaComoTextoFinal = GenereElDiaComoTextoFormateado(losDatos);
        }

        private string GenereElAñoComoTexto(DatosParaElRequerimiento losDatos)
        {
            return new Año(losDatos).ComoTexto();
        }

        private string GenereElMesComoTextoFormateado(DatosParaElRequerimiento losDatos)
        {
            return new MesComoTexto(losDatos).Formateado();
        }

        private string GenereElDiaComoTextoFormateado(DatosParaElRequerimiento losDatos)
        {
            return new DiaComoTexto(losDatos).Formateado();
        }

        public string ComoTexto()
        {
            return elAñoComoTextoFinal + elMesComoTextoFinal + elDiaComoTextoFinal;
        }
    }
}
