﻿using jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo;
using System;

namespace jcamposc889.Negocio.EstructuraDeDatos.ConParameterObject
{
    public class ValorTransadoBrutoConTratamiento
    {
        DatosDeInversionConTratamientoFiscal losDatosConTratamiento;

        public ValorTransadoBrutoConTratamiento(DatosParaLaInversion losDatos)
        {
            losDatosConTratamiento = AsigneLosDatosConTratamiento(losDatos);
        }

        private DatosDeInversionConTratamientoFiscal AsigneLosDatosConTratamiento(DatosParaLaInversion losDatos)
        {
            DatosDeInversionConTratamientoFiscal losDatosConTratamiento = new DatosDeInversionConTratamientoFiscal();
            //TODO: ARREGLAR ESTOS DETALLES
            losDatosConTratamiento.ValorFacial = losDatos.ValorFacial;
            losDatosConTratamiento.ValorTransadoNeto = losDatos.ValorTransadoNeto;
            losDatosConTratamiento.TasaDeImpuesto = losDatos.TasaDeImpuesto;
            losDatosConTratamiento.FechaActual = losDatos.FechaActual;
            losDatosConTratamiento.FechaDeVencimiento = losDatos.FechaDeVencimiento;

            return losDatosConTratamiento;
        }

        public double ComoNumero()
        {
            return new ValorTransadoBrutoConTratamientoFiscal(losDatosConTratamiento).ComoNumero();
        }
    }
}
