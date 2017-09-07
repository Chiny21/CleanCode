namespace jcamposc889.Negocio.CodigosDeReferencia.ConTellDontAsk
{
    public class MesComoTexto
    {
        private string elMesComoTexto;

        public MesComoTexto(DatosParaElRequerimiento losDatos)
        {
            elMesComoTexto = new Mes(losDatos).ComoTexto();
        }

        public string Formateado()
        {
            return elMesComoTexto.PadLeft(2, '0');
        }
    }
}
