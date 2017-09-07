using jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo;

namespace jcamposc889.Negocio.EstructuraDeDatos.ConTellDontAsk
{
    public class TasaBrutaConTratamiento
    {
        DatosDeInversionConTratamientoFiscal losDatosConTratamiento;

        public TasaBrutaConTratamiento(DatosParaLaInversion losDatos)
        {
            losDatosConTratamiento = AsigneLosDatosConTratamiento(losDatos);
        }

        private DatosDeInversionConTratamientoFiscal AsigneLosDatosConTratamiento(DatosParaLaInversion losDatos)
        {
            DatosDeInversionConTratamientoFiscal losDatosConTratamiento = new DatosDeInversionConTratamientoFiscal();
            losDatosConTratamiento.ValorFacial = losDatos.ValorFacial;
            losDatosConTratamiento.ValorTransadoNeto = losDatos.ValorTransadoNeto;
            losDatosConTratamiento.TasaDeImpuesto = losDatos.TasaDeImpuesto;
            losDatosConTratamiento.FechaActual = losDatos.FechaActual;
            losDatosConTratamiento.FechaDeVencimiento = losDatos.FechaDeVencimiento;

            return losDatosConTratamiento;
        }

        public double ComoNumero()
        {
            return new TasaBruta(losDatosConTratamiento).Calculado();
        }
    }
}
