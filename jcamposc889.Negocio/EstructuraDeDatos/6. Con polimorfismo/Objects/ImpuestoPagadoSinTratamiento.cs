using jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo;

namespace jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo
{
    public class ImpuestoPagadoSinTratamiento
    {
        DatosDeInversionSinTratamientoFiscal losDatosSinTratamiento;

        public ImpuestoPagadoSinTratamiento(DatosParaLaInversion losDatos)
        {
            losDatosSinTratamiento = new DatosDeInversionSinTratamientoFiscal();

            losDatosSinTratamiento.ValorFacial = losDatos.ValorFacial;
            losDatosSinTratamiento.ValorTransadoNeto = losDatos.ValorTransadoNeto;
            losDatosSinTratamiento.TasaDeImpuesto = losDatos.TasaDeImpuesto;
            losDatosSinTratamiento.FechaActual = losDatos.FechaActual;
            losDatosSinTratamiento.FechaDeVencimiento = losDatos.FechaDeVencimiento;
        }

        public double ComoNumero()
        {
            return losDatosSinTratamiento.Impuesto;
        }
    }
}
