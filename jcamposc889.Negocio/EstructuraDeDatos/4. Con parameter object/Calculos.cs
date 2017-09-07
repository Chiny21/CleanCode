using System;

namespace jcamposc889.Negocio.EstructuraDeDatos.ConParameterObject
{
    public static class Calculos
    {
        public static Inversion GenereUnaNuevaInversion(DatosParaLaInversion losDatos)
        {
            Inversion laNuevaInversion = new Inversion();

            laNuevaInversion.CodigoDeReferencia = GenereElCodigoDeReferencia(losDatos);
            laNuevaInversion.TasaNeta = CalculeLaTasaNeta(losDatos);
            laNuevaInversion.TasaBruta = CalculeLaTasaBruta(losDatos);
            laNuevaInversion.ValorTransadoBruto = CalculeElValorTransadoBruto(losDatos);
            laNuevaInversion.ImpuestoPagado = CalculeElImpuestoPagado(losDatos);
            laNuevaInversion.RendimientoPorDescuento = CalculeElRendimientoPorDescuento(losDatos);
            //TODO: ARREGLAR ESTOS DETALLES
            laNuevaInversion.FechaDeValor = losDatos.FechaActual;
            laNuevaInversion.FechaDeVencimiento = losDatos.FechaDeVencimiento;

            return laNuevaInversion;
        }

        private static string GenereElCodigoDeReferencia(DatosParaLaInversion losDatos)
        {
            return new CodigoDeReferenciaParaInversion(losDatos).ComoTexto();
        }

        private static double CalculeLaTasaNeta(DatosParaLaInversion losDatos)
        {
            if (losDatos.tieneTratamientoFiscal)
                return GenereLaTasaNetaConTratamiento(losDatos);
            else
                return GenereLaTasaNetaSinTratamiento(losDatos);
        }

        private static double GenereLaTasaNetaConTratamiento(DatosParaLaInversion losDatos)
        {
            return new TasaNetaConTratamiento(losDatos).ComoNumero();
        }

        private static double GenereLaTasaNetaSinTratamiento(DatosParaLaInversion losDatos)
        {
            return new TasaNetaSinTratamiento(losDatos).ComoNumero();
        }

        private static double CalculeLaTasaBruta(DatosParaLaInversion losDatos)
        {
            if (losDatos.tieneTratamientoFiscal)
                return GenereLaTasaBrutaConTratamiento(losDatos);
            else
                return GenereLaTasaBrutaSinTratamiento(losDatos);
        }

        private static double GenereLaTasaBrutaConTratamiento(DatosParaLaInversion losDatos)
        {
            return new TasaBrutaConTratamiento(losDatos).ComoNumero();
        }

        private static double GenereLaTasaBrutaSinTratamiento(DatosParaLaInversion losDatos)
        {
            return new TasaBrutaSinTratamiento(losDatos).ComoNumero();
        }

        private static double CalculeElValorTransadoBruto(DatosParaLaInversion losDatos)
        {
            if (losDatos.tieneTratamientoFiscal)
                return GenereElValorTransadoBrutoConTratamiento(losDatos);
            else
                return GenereElValorTransadoBrutoSinTratamiento(losDatos);
        }

        private static double GenereElValorTransadoBrutoConTratamiento(DatosParaLaInversion losDatos)
        {
            return new ValorTransadoBrutoConTratamiento(losDatos).ComoNumero();
        }

        private static double GenereElValorTransadoBrutoSinTratamiento(DatosParaLaInversion losDatos)
        {
            return losDatos.ValorTransadoNeto;
        }

        private static double CalculeElImpuestoPagado(DatosParaLaInversion losDatos)
        {
            if (losDatos.tieneTratamientoFiscal)
                return GenereElImpuestoPagadoConTratamiento(losDatos);
            else
                return GenereElImpuestoPagadoSinTratamiento(losDatos);
        }

        private static double GenereElImpuestoPagadoConTratamiento(DatosParaLaInversion losDatos)
        {
            return new ImpuestoPagadoConTratamiento(losDatos).ComoNumero();
        }

        private static double GenereElImpuestoPagadoSinTratamiento(DatosParaLaInversion losDatos)
        {
            return new ImpuestoPagadoSinTratamiento(losDatos).ComoNumero();
        }

        private static double CalculeElRendimientoPorDescuento(DatosParaLaInversion losDatos)
        {
            if (losDatos.tieneTratamientoFiscal)
                return GenereElRendimientoPorDescuentoConTratamiento(losDatos);
            else
                return GenereElRendimientoPorDescuentoSinTratamiento(losDatos);
        }

        private static double GenereElRendimientoPorDescuentoConTratamiento(DatosParaLaInversion losDatos)
        {
            return new RendimientoPorDescuentoConTratamiento(losDatos).ComoNumero();
        }

        private static double GenereElRendimientoPorDescuentoSinTratamiento(DatosParaLaInversion losDatos)
        {
            return new RendimientoPorDescuentoSinTratamiento(losDatos).ComoNumero();
        }
    }
}
