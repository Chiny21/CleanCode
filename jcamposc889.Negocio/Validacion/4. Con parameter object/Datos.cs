namespace jcamposc889.Negocio.Validacion.ConParameterObject
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
            // TODO: HAY MAS DE UNA OPERACION
            if (losDatos.elValorFacial > 100000)
                return true;
            else
                return false;
        }

        private bool ValideElValorTransadoNeto(DatosParaVerificar losDatos)
        {
            // TODO: HAY MAS DE UNA OPERACION
            if (losDatos.elValorTransadoNeto > 100000)
                return true;
            else
                return false;
        }

        private bool ValideLaTasaDeImpuesto(DatosParaVerificar losDatos)
        {
            // TODO: HAY MAS DE UNA OPERACION
            if (losDatos.laTasaDeImpuesto > 0 && losDatos.laTasaDeImpuesto < 1)
                return true;
            else
                return false;
        }

        private bool ValideLaFechaActual(DatosParaVerificar losDatos)
        {
            // TODO: HAY MAS DE UNA OPERACION
            if (losDatos.laFechaActual < losDatos.laFechaDeVencimiento)
                return true;
            else
                return false;
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
