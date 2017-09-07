namespace jcamposc889.Negocio.CodigosDeReferencia.ConParameterObject
{
    public class Año
    {
        private int elAño;

        public Año(DatosParaElRequerimiento losDatos)
        {
            // TODO: NO CUMPLE CON LA LEY DE DEMETER
            elAño = losDatos.Fecha.Year;
        }

        public string ComoTexto()
        {
            return elAño.ToString();
        }
    }
}
