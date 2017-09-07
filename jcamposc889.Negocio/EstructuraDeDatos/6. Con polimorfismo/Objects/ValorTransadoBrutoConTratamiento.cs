﻿using jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo;

namespace jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo
{
    public class ValorTransadoBrutoConTratamiento
    {
        DatosDeInversionConTratamientoFiscal losDatosConTratamiento;

        public ValorTransadoBrutoConTratamiento(DatosParaLaInversion losDatos)
        {
            losDatosConTratamiento = new DatosDeInversionConTratamientoFiscal();

            losDatosConTratamiento.ValorFacial = losDatos.ValorFacial;
            losDatosConTratamiento.ValorTransadoNeto = losDatos.ValorTransadoNeto;
            losDatosConTratamiento.TasaDeImpuesto = losDatos.TasaDeImpuesto;
            losDatosConTratamiento.FechaActual = losDatos.FechaActual;
            losDatosConTratamiento.FechaDeVencimiento = losDatos.FechaDeVencimiento;
        }

        public double ComoNumero()
        {
            return new ValorTransadoBrutoConTratamientoFiscal(losDatosConTratamiento).ComoNumero();
        }
    }
}
