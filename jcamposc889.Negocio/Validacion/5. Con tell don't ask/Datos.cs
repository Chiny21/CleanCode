namespace jcamposc889.Negocio.Validacion.ConTellDontAsk
{
    public class Datos
    {
        private bool laValidezDelValorFacial;
        private bool laValidezDelValorTransadoNeto;
        private bool laValidezDeLaTasaDeImpuesto;
        private bool laValidezDeLaFechaActual;

        public Datos(DatosParaVerificar losDatos)
        {
            laValidezDelValorFacial = ValideElValorFacial(losDatos);
            laValidezDelValorTransadoNeto = ValideElValorTransadoNeto(losDatos);
            laValidezDeLaTasaDeImpuesto = ValideLaTasaDeImpuesto(losDatos);
            laValidezDeLaFechaActual = ValideLaFechaActual(losDatos);
        }

        private bool ValideElValorFacial(DatosParaVerificar losDatos)
        {
            return losDatos.ElValorFacialEsValido();
        }

        private bool ValideElValorTransadoNeto(DatosParaVerificar losDatos)
        {
            return losDatos.ElValorTransadoNetoEsValido();
        }

        private bool ValideLaTasaDeImpuesto(DatosParaVerificar losDatos)
        {
            return losDatos.LaTasaDeImpuestoEsValida();
        }

        private bool ValideLaFechaActual(DatosParaVerificar losDatos)
        {
            return losDatos.LaFechaActualEsValida();
        }

        public bool SonValidos()
        {
            if (laValidezDelValorFacial && laValidezDelValorTransadoNeto &&
                laValidezDeLaTasaDeImpuesto && laValidezDeLaFechaActual)
                return true;
            else
                return false;
        }
    }
}
