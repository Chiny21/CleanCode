using System;
using jcamposc889.Negocio.CodigosDeReferencia.ConTellDontAsk;
using jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo;

namespace jcamposc889.Negocio.EstructuraDeDatos.ConFunciones
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
            DatosParaElRequerimiento losDatosParaElRequerimiento = AsigneLosDatosParaElRequerimiento(laFechaActual, elConsecutivoParaElCodigoDeReferencia);

            return AsigneElCodigoDeReferencia(losDatosParaElRequerimiento);
        }

        private static DatosParaElRequerimiento AsigneLosDatosParaElRequerimiento(DateTime laFechaActual, string elConsecutivoParaElCodigoDeReferencia)
        {
            DatosParaElRequerimiento losDatosParaElRequerimiento = new DatosParaElRequerimiento();

            losDatosParaElRequerimiento.Fecha = laFechaActual;
            losDatosParaElRequerimiento.NumeroDelCliente = "22";
            losDatosParaElRequerimiento.NumeroDelSistema = "5";
            losDatosParaElRequerimiento.NumeroConsecutivo = elConsecutivoParaElCodigoDeReferencia;

            return losDatosParaElRequerimiento;
        }

        private static string AsigneElCodigoDeReferencia(DatosParaElRequerimiento losDatosParaElRequerimiento)
        {
            return new CodigoDeReferencia(losDatosParaElRequerimiento).ComoTexto();
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
            DatosDeInversionConTratamientoFiscal losDatosConTratamiento = AsigneLosDatosConTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento);

            return AsigneLaTasaNetaConTratamiento(losDatosConTratamiento);
        }

        private static DatosDeInversionConTratamientoFiscal AsigneLosDatosConTratamiento(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento)
        {
            DatosDeInversionConTratamientoFiscal losDatosConTratamiento = new DatosDeInversionConTratamientoFiscal();

            losDatosConTratamiento.ValorFacial = elValorFacial;
            losDatosConTratamiento.ValorTransadoNeto = elValorTransadoNeto;
            losDatosConTratamiento.TasaDeImpuesto = laTasaDeImpuesto;
            losDatosConTratamiento.FechaActual = laFechaActual;
            losDatosConTratamiento.FechaDeVencimiento = laFechaDeVencimiento;

            return losDatosConTratamiento;
        }

        private static double AsigneLaTasaNetaConTratamiento(DatosDeInversionConTratamientoFiscal losDatosConTratamiento)
        {
            return losDatosConTratamiento.TasaNeta;
        }

        private static double GenereLaTasaNetaSinTratamiento(double elValorFacial, double elValorTransadoNeto,
            double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento)
        {
            DatosDeInversionSinTratamientoFiscal losDatosSinTratamiento = AsigneLosDatosSinTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento);

            return AsigneLaTasaNetaSinTratamiento(losDatosSinTratamiento);
        }

        private static DatosDeInversionSinTratamientoFiscal AsigneLosDatosSinTratamiento(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento)
        {
            DatosDeInversionSinTratamientoFiscal losDatosSinTratamiento = new DatosDeInversionSinTratamientoFiscal();

            losDatosSinTratamiento.ValorFacial = elValorFacial;
            losDatosSinTratamiento.ValorTransadoNeto = elValorTransadoNeto;
            losDatosSinTratamiento.TasaDeImpuesto = laTasaDeImpuesto;
            losDatosSinTratamiento.FechaActual = laFechaActual;
            losDatosSinTratamiento.FechaDeVencimiento = laFechaDeVencimiento;

            return losDatosSinTratamiento;
        }

        private static double AsigneLaTasaNetaSinTratamiento(DatosDeInversionSinTratamientoFiscal losDatosSinTratamiento)
        {
            return losDatosSinTratamiento.TasaNeta;
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
            DatosDeInversionConTratamientoFiscal losDatosConTratamiento = AsigneLosDatosConTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento);

            return AsigneLaTasaBrutaConTratamiento(losDatosConTratamiento);
        }

        private static double AsigneLaTasaBrutaConTratamiento(DatosDeInversionConTratamientoFiscal losDatosConTratamiento)
        {
            return new TasaBruta(losDatosConTratamiento).Calculado();
        }

        private static double GenereLaTasaBrutaSinTratamiento(double elValorFacial, double elValorTransadoNeto,
            double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento)
        {
            DatosDeInversionSinTratamientoFiscal losDatosSinTratamiento = AsigneLosDatosSinTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento);

            return AsigneLaTasaBrutaSinTratamiento(losDatosSinTratamiento);
        }

        private static double AsigneLaTasaBrutaSinTratamiento(DatosDeInversionSinTratamientoFiscal losDatosSinTratamiento)
        {
            return new TasaBruta(losDatosSinTratamiento).Calculado();
        }

        private static double CalculeElValorTransadoBruto(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento, bool tieneTratamientoFiscal, Inversion laNuevaInversion)
        {
            if (tieneTratamientoFiscal)
                return GenereElValorTransadoBrutoConTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento);
            else
                return elValorTransadoNeto;
        }

        private static double GenereElValorTransadoBrutoConTratamiento(double elValorFacial, double elValorTransadoNeto,
            double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento)
        {
            DatosDeInversionConTratamientoFiscal losDatosConTratamiento = AsigneLosDatosConTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento);

            return AsigneElValorTransadoBrutoConTratamiento(losDatosConTratamiento);
        }

        private static double AsigneElValorTransadoBrutoConTratamiento(DatosDeInversionConTratamientoFiscal losDatosConTratamiento)
        {
            return new ValorTransadoBrutoConTratamientoFiscal(losDatosConTratamiento).ComoNumero();
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
            DatosDeInversionConTratamientoFiscal losDatosConTratamiento = AsigneLosDatosConTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento);

            return AsigneElImpuestoPagadoConTratamiento(losDatosConTratamiento);
        }

        private static double AsigneElImpuestoPagadoConTratamiento(DatosDeInversionConTratamientoFiscal losDatosConTratamiento)
        {
            return losDatosConTratamiento.Impuesto;
        }

        private static double GenereElImpuestoPagadoSinTratamiento(double elValorFacial, double elValorTransadoNeto,
            double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento)
        {
            DatosDeInversionSinTratamientoFiscal losDatosSinTratamiento = AsigneLosDatosSinTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento);

            return AsigneElImpuestoPagadoSinTratamiento(losDatosSinTratamiento);
        }

        private static double AsigneElImpuestoPagadoSinTratamiento(DatosDeInversionSinTratamientoFiscal losDatosSinTratamiento)
        {
            return losDatosSinTratamiento.Impuesto;
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
            DatosDeInversionConTratamientoFiscal losDatosConTratamiento = AsigneLosDatosConTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento);

            return AsigneElRendimientoPorDescuentoConTratamiento(losDatosConTratamiento);
        }

        private static double AsigneElRendimientoPorDescuentoConTratamiento(DatosDeInversionConTratamientoFiscal losDatosConTratamiento)
        {
            return new RendimientosPorDescuento(losDatosConTratamiento).ComoNumero();
        }

        private static double GenereElRendimientoPorDescuentoSinTratamiento(double elValorFacial, double elValorTransadoNeto,
           double laTasaDeImpuesto, DateTime laFechaActual, DateTime laFechaDeVencimiento)
        {
            DatosDeInversionSinTratamientoFiscal losDatosSinTratamiento = AsigneLosDatosSinTratamiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaActual, laFechaDeVencimiento);

            return AsigneElRendimientoPorDescuentoSinTratamiento(losDatosSinTratamiento);
        }

        private static double AsigneElRendimientoPorDescuentoSinTratamiento(DatosDeInversionSinTratamientoFiscal losDatosSinTratamiento)
        {
            return new RendimientosPorDescuento(losDatosSinTratamiento).ComoNumero();
        }
    }
}
