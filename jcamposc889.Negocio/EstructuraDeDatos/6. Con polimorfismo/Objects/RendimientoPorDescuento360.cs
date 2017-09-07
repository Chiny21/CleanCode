﻿using jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo;

namespace jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo
{
    public class RendimientoPorDescuento360
    {
        DatosDeInversion360 losDatos360;

        public RendimientoPorDescuento360(DatosParaLaInversion losDatos)
        {
            losDatos360 = new DatosDeInversion360();

            losDatos360.ValorFacial = losDatos.ValorFacial;
            losDatos360.ValorTransadoNeto = losDatos.ValorTransadoNeto;
            losDatos360.TasaDeImpuesto = losDatos.TasaDeImpuesto;
            losDatos360.FechaActual = losDatos.FechaActual;
            losDatos360.FechaDeVencimiento = losDatos.FechaDeVencimiento;
        }

        public double ComoNumero()
        {
            return new RendimientosPorDescuento(losDatos360).ComoNumero();
        }
    }
}
