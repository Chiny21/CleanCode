namespace jcamposc889.Negocio.CodigosDeReferencia.ConTellDontAsk
{
    public class Mes
    {
        private int elMes;

        public Mes(DatosParaElRequerimiento losDatos)
        {
            elMes = losDatos.MesDeLaFecha;
        }

        public string ComoTexto()
        {
            return elMes.ToString();
        }
    }
}
