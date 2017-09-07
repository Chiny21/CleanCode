namespace jcamposc889.Negocio.CodigosDeReferencia.ConParameterObject
{
    public class Dia
    {
        private int elDia;

        public Dia(DatosParaElRequerimiento losDatos)
        {
            // TODO: NO CUMPLE CON LA LEY DE DEMETER
            elDia = losDatos.Fecha.Day;
        }

        public string ComoTexto()
        {
            return elDia.ToString();
        }
    }
}
