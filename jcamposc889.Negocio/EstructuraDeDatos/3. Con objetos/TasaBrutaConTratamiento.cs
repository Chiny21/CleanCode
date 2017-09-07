using jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo;
using System;

namespace jcamposc889.Negocio.EstructuraDeDatos.ConObjetos
{
    public class TasaBrutaConTratamiento
    {
        DatosDeInversionConTratamientoFiscal losDatosConTratamiento;

        public TasaBrutaConTratamiento(double elValorFacial, double elValorTransadoNeto,
            double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento)
        {
            losDatosConTratamiento = AsigneLosDatosConTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento);
        }

        private DatosDeInversionConTratamientoFiscal AsigneLosDatosConTratamiento(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento)
        {
            DatosDeInversionConTratamientoFiscal losDatosConTratamiento = new DatosDeInversionConTratamientoFiscal();

            losDatosConTratamiento.ValorFacial = elValorFacial;
            losDatosConTratamiento.ValorTransadoNeto = elValorTransadoNeto;
            losDatosConTratamiento.TasaDeImpuesto = laTasaDeImpuesto;
            losDatosConTratamiento.FechaActual = laFechaActual;
            losDatosConTratamiento.FechaDeVencimiento = laFechaDeVencimiento;

            return losDatosConTratamiento;
        }

        public double ComoNumero()
        {
            return new TasaBruta(losDatosConTratamiento).Calculado();
        }
    }
}
