namespace jcamposc889.Negocio.CodigosDeReferencia.ConTellDontAsk
{
    public class Año
    {
        private int elAño;

        public Año(DatosParaElRequerimiento losDatos)
        {
            elAño = losDatos.AñoDeLaFecha;
        }

        public string ComoTexto()
        {
            return elAño.ToString();
        }
    }
}
