namespace jcamposc889.Negocio.CodigosDeReferencia.ConTellDontAsk
{
    public class Dia
    {
        private int elDia;

        public Dia(DatosParaElRequerimiento losDatos)
        {
            elDia = losDatos.DiaDeLaFecha;
        }

        public string ComoTexto()
        {
            return elDia.ToString();
        }
    }
}
