using System;

namespace jcamposc889.Negocio.EstructuraDeDatos.ConObjetos
{
    public static class Calculos
    {
        public static Inversion GenereUnaNuevaInversion(double elValorFacial, double elValorTransadoNeto,
            double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento,
            bool tieneTratamientoFiscal, string elConsecutivoParaElCodigoDeReferencia)
        {
            Inversion laNuevaInversion = new Inversion();

            laNuevaInversion.CodigoDeReferencia = GenereElCodigoDeReferencia(laFechaActual, elConsecutivoParaElCodigoDeReferencia);
            laNuevaInversion.TasaNeta = CalculeLaTasaNeta(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento, tieneTratamientoFiscal, laNuevaInversion);
            laNuevaInversion.TasaBruta = CalculeLaTasaBruta(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento, tieneTratamientoFiscal, laNuevaInversion);
            laNuevaInversion.ValorTransadoBruto = CalculeElValorTransadoBruto(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento, tieneTratamientoFiscal, laNuevaInversion);
            laNuevaInversion.ImpuestoPagado = CalculeElImpuestoPagado(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento, tieneTratamientoFiscal, laNuevaInversion);
            laNuevaInversion.RendimientoPorDescuento = CalculeElRendimientoPorDescuento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento, tieneTratamientoFiscal, laNuevaInversion);
            laNuevaInversion.FechaDeValor = laFechaActual;
            laNuevaInversion.FechaDeVencimiento = laFechaDeVencimiento;

            return laNuevaInversion;
        }

        private static string GenereElCodigoDeReferencia(DateTime laFechaActual, string elConsecutivoParaElCodigoDeReferencia)
        {
            return new CodigoDeReferenciaParaInversion(laFechaActual, elConsecutivoParaElCodigoDeReferencia).ComoTexto();
        }

        private static double CalculeLaTasaNeta(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento, bool tieneTratamientoFiscal, Inversion laNuevaInversion)
        {
            if (tieneTratamientoFiscal)
                return GenereLaTasaNetaConTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento);
            else
                return GenereLaTasaNetaSinTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento);
        }

        private static double GenereLaTasaNetaConTratamiento(double elValorFacial, double elValorTransadoNeto,
           double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento)
        {
            return new TasaNetaConTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento).ComoNumero();
        }

        private static double GenereLaTasaNetaSinTratamiento(double elValorFacial, double elValorTransadoNeto,
            double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento)
        {
            return new TasaNetaSinTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento).ComoNumero();
        }

        private static double CalculeLaTasaBruta(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento, bool tieneTratamientoFiscal, Inversion laNuevaInversion)
        {
            if (tieneTratamientoFiscal)
                return GenereLaTasaBrutaConTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento);
            else
                return GenereLaTasaBrutaSinTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento);
        }

        private static double GenereLaTasaBrutaConTratamiento(double elValorFacial, double elValorTransadoNeto,
            double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento)
        {
            return new TasaBrutaConTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento).ComoNumero();
        }

        private static double GenereLaTasaBrutaSinTratamiento(double elValorFacial, double elValorTransadoNeto,
            double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento)
        {
            return new TasaBrutaSinTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento).ComoNumero();
        }

        private static double CalculeElValorTransadoBruto(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento, bool tieneTratamientoFiscal, Inversion laNuevaInversion)
        {
            if (tieneTratamientoFiscal)
                return GenereElValorTransadoBrutoConTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento);
            else
                return GenereElValorTransadoBrutoSinTratamiento(elValorTransadoNeto);
        }

        private static double GenereElValorTransadoBrutoConTratamiento(double elValorFacial, double elValorTransadoNeto,
            double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento)
        {
            return new ValorTransadoBrutoConTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento).ComoNumero();
        }

        private static double GenereElValorTransadoBrutoSinTratamiento(double elValorTransadoNeto)
        {
            return elValorTransadoNeto;
        }

        private static double CalculeElImpuestoPagado(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento, bool tieneTratamientoFiscal, Inversion laNuevaInversion)
        {
            if (tieneTratamientoFiscal)
                return GenereElImpuestoPagadoConTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento);
            else
                return GenereElImpuestoPagadoSinTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento);
        }

        private static double GenereElImpuestoPagadoConTratamiento(double elValorFacial, double elValorTransadoNeto,
           double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento)
        {
            return new ImpuestoPagadoConTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento).ComoNumero();
        }

        private static double GenereElImpuestoPagadoSinTratamiento(double elValorFacial, double elValorTransadoNeto,
            double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento)
        {
            return new ImpuestoPagadoSinTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento).ComoNumero();
        }

        private static double CalculeElRendimientoPorDescuento(double elValorFacial, double elValorTransadoNeto,
            double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento,
            bool tieneTratamientoFiscal, Inversion laNuevaInversion)
        {
            if (tieneTratamientoFiscal)
                return GenereElRendimientoPorDescuentoConTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento);
            else
                return GenereElRendimientoPorDescuentoSinTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento);
        }

        private static double GenereElRendimientoPorDescuentoConTratamiento(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento)
        {
            return new RendimientoPorDescuentoConTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento).ComoNumero();
        }

        private static double GenereElRendimientoPorDescuentoSinTratamiento(double elValorFacial, double elValorTransadoNeto,
           double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento)
        {
            return new RendimientoPorDescuentoSinTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento).ComoNumero();
        }
    }
}
