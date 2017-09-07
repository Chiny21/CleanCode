using jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo;

namespace jcamposc889.Negocio.EstructuraDeDatos.ConTellDontAsk
{
    public class RendimientoPorDescuentoSinTratamiento
    {
        DatosDeInversionSinTratamientoFiscal losDatosSinTratamiento;

        public RendimientoPorDescuentoSinTratamiento(DatosParaLaInversion losDatos)
        {
            losDatosSinTratamiento = AsigneLosDatosSinTratamiento(losDatos);
        }

        private DatosDeInversionSinTratamientoFiscal AsigneLosDatosSinTratamiento(DatosParaLaInversion losDatos)
        {
            DatosDeInversionSinTratamientoFiscal losDatosSinTratamiento = new DatosDeInversionSinTratamientoFiscal();
            losDatosSinTratamiento.ValorFacial = losDatos.ValorFacial;
            losDatosSinTratamiento.ValorTransadoNeto = losDatos.ValorTransadoNeto;
            losDatosSinTratamiento.TasaDeImpuesto = losDatos.TasaDeImpuesto;
            losDatosSinTratamiento.FechaActual = losDatos.FechaActual;
            losDatosSinTratamiento.FechaDeVencimiento = losDatos.FechaDeVencimiento;

            return losDatosSinTratamiento;
        }

        public double ComoNumero()
        {
            return new RendimientosPorDescuento(losDatosSinTratamiento).ComoNumero();
        }
    }
}
