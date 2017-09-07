using System;
using jcamposc889.Negocio.CodigosDeReferencia.ConTellDontAsk;
using jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo;

namespace jcamposc889.Negocio.EstructuraDeDatos.ComoUnProcedimiento
{
    public static class Calculos
    {
        public static Inversion GenereUnaNuevaInversion(double elValorFacial,
            double elValorTransadoNeto,
            double laTasaDeImpuesto,
            DateTime laFechaActual,
            DateTime laFechaDeVencimiento,
            bool tieneTratamientoFiscal,
            string elConsecutivoParaElCodigoDeReferencia)
        {
            Inversion laNuevaInversion = new Inversion();

            DatosParaElRequerimiento losDatosParaElRequerimiento = new DatosParaElRequerimiento();
            losDatosParaElRequerimiento.Fecha = laFechaActual;
            losDatosParaElRequerimiento.NumeroDelCliente = "22";
            losDatosParaElRequerimiento.NumeroDelSistema = "5";
            losDatosParaElRequerimiento.NumeroConsecutivo = elConsecutivoParaElCodigoDeReferencia;

            laNuevaInversion.CodigoDeReferencia = new CodigoDeReferencia(losDatosParaElRequerimiento).ComoTexto();

            if (tieneTratamientoFiscal)
            {
                DatosDeInversionConTratamientoFiscal losDatosConTratamiento = new DatosDeInversionConTratamientoFiscal();
                losDatosConTratamiento.ValorFacial = elValorFacial;
                losDatosConTratamiento.ValorTransadoNeto = elValorTransadoNeto;
                losDatosConTratamiento.TasaDeImpuesto = laTasaDeImpuesto;
                losDatosConTratamiento.FechaActual = laFechaActual;
                losDatosConTratamiento.FechaDeVencimiento = laFechaDeVencimiento;

                laNuevaInversion.TasaNeta = losDatosConTratamiento.TasaNeta;
                laNuevaInversion.TasaBruta = new TasaBruta(losDatosConTratamiento).Calculado();
                laNuevaInversion.ValorTransadoBruto = new ValorTransadoBrutoConTratamientoFiscal(losDatosConTratamiento).ComoNumero();
                laNuevaInversion.ImpuestoPagado = losDatosConTratamiento.Impuesto;
                laNuevaInversion.RendimientoPorDescuento = new RendimientosPorDescuento(losDatosConTratamiento).ComoNumero();
            }
            else
            {
                DatosDeInversionSinTratamientoFiscal losDatosSinTratamiento = new DatosDeInversionSinTratamientoFiscal();
                losDatosSinTratamiento.ValorFacial = elValorFacial;
                losDatosSinTratamiento.ValorTransadoNeto = elValorTransadoNeto;
                losDatosSinTratamiento.TasaDeImpuesto = laTasaDeImpuesto;
                losDatosSinTratamiento.FechaActual = laFechaActual;
                losDatosSinTratamiento.FechaDeVencimiento = laFechaDeVencimiento;

                laNuevaInversion.TasaNeta = losDatosSinTratamiento.TasaNeta;
                laNuevaInversion.TasaBruta = new TasaBruta(losDatosSinTratamiento).Calculado();
                laNuevaInversion.ValorTransadoBruto = elValorTransadoNeto;
                laNuevaInversion.ImpuestoPagado = losDatosSinTratamiento.Impuesto;
                laNuevaInversion.RendimientoPorDescuento = new RendimientosPorDescuento(losDatosSinTratamiento).ComoNumero();
            }

            laNuevaInversion.FechaDeValor = laFechaActual;
            laNuevaInversion.FechaDeVencimiento = laFechaDeVencimiento;

            return laNuevaInversion;

        }
    }
}
