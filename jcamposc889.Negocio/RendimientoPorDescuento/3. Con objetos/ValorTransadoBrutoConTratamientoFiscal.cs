using System;

namespace jcamposc889.Negocio.RendimientoPorDescuento.ConObjetos
{
    public class ValorTransadoBrutoConTratamientoFiscal
    {
        private double elValorFacial;
        private double losDiasAlVencimientoComoNumero;
        private double laTasaBruta;

        public ValorTransadoBrutoConTratamientoFiscal(double elValorFacial, 
            double elValorTransadoNeto, double laTasaDeImpuesto, 
            DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            this.elValorFacial = elValorFacial;
            losDiasAlVencimientoComoNumero = GenereLosDiasAlVencimiento(laFechaDeVencimiento, laFechaActual);
            laTasaBruta = GenereLaTasaBruta(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, losDiasAlVencimientoComoNumero);
        }

        private double GenereLosDiasAlVencimiento(DateTime laFechaDeVencimiento,
            DateTime laFechaActual)
        {
            return new DiasAlVencimiento(laFechaDeVencimiento, laFechaActual).ComoNumero();
        }

        private double GenereLaTasaBruta(double elValorFacial, double elValorTransadoNeto,
            double laTasaDeImpuesto, double losDiasAlVencimientoComoNumero)
        {
            return new TasaBruta(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, losDiasAlVencimientoComoNumero).Calculado();
        }

        public double ComoNumero()
        {
            return elValorFacial / (1 + (laTasaBruta / 100) * (losDiasAlVencimientoComoNumero / 365));
        }
    }
}
