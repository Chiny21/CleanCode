﻿using jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo;
using System;

namespace jcamposc889.Negocio.EstructuraDeDatos.ConParameterObject
{
    public class TasaNetaSinTratamiento
    {
        DatosDeInversionSinTratamientoFiscal losDatosSinTratamiento;

        public TasaNetaSinTratamiento(DatosParaLaInversion losDatos)
        {
            losDatosSinTratamiento = AsigneLosDatosSinTratamiento(losDatos);
        }

        private DatosDeInversionSinTratamientoFiscal AsigneLosDatosSinTratamiento(DatosParaLaInversion losDatos)
        {
            DatosDeInversionSinTratamientoFiscal losDatosSinTratamiento = new DatosDeInversionSinTratamientoFiscal();
            //TODO: ARREGLAR ESTOS DETALLES
            losDatosSinTratamiento.ValorFacial = losDatos.ValorFacial;
            losDatosSinTratamiento.ValorTransadoNeto = losDatos.ValorTransadoNeto;
            losDatosSinTratamiento.TasaDeImpuesto = losDatos.TasaDeImpuesto;
            losDatosSinTratamiento.FechaActual = losDatos.FechaActual;
            losDatosSinTratamiento.FechaDeVencimiento = losDatos.FechaDeVencimiento;

            return losDatosSinTratamiento;
        }

        public double ComoNumero()
        {
            return losDatosSinTratamiento.TasaNeta;
        }
    }
}
