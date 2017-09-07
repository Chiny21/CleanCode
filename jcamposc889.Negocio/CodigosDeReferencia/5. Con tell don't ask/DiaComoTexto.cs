namespace jcamposc889.Negocio.CodigosDeReferencia.ConTellDontAsk
{
    public class DiaComoTexto
    {
        private string elDiaComoTexto;

        public DiaComoTexto(DatosParaElRequerimiento losDatos)
        {
            elDiaComoTexto = new Dia(losDatos).ComoTexto();
        }

        public string Formateado()
        {
            return elDiaComoTexto.PadLeft(2, '0');
        }
    }
}
