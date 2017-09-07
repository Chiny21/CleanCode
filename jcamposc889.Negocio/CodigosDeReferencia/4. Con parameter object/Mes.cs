namespace jcamposc889.Negocio.CodigosDeReferencia.ConParameterObject
{
    public class Mes
    {
        private int elMes;

        public Mes(DatosParaElRequerimiento losDatos)
        {
            // TODO: NO CUMPLE CON LA LEY DE DEMETER
            elMes = losDatos.Fecha.Month;
        }

        public string ComoTexto()
        {
            return elMes.ToString();
        }
    }
}
