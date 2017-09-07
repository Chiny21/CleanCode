using System;

namespace jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo
{
    public class Inversion
    {
        private DatosParaLaInversion losDatos;

        public Inversion(DatosParaLaInversion losDatos)
        {
            this.losDatos = losDatos;
        }

        public string CodigoDeReferencia
        {
            get
            {
                return new CodigoDeReferenciaParaInversion(losDatos).ComoTexto();
            }
        }

        public double TasaNeta
        {
            get
            {
                return losDatos.TasaNeta;
            }
        }

        public double TasaBruta
        {
            get
            {
                return losDatos.TasaBruta;
            }
        }

        public double ValorTransadoBruto
        {
            get
            {
                return losDatos.ValorTransadoBruto;
            }
        }

        public double ImpuestoPagado
        {
            get
            {
                return losDatos.ImpuestoPagado;
            }
        }

        public double RendimientoPorDescuento
        {
            get
            {
                return losDatos.RendimientoPorDescuento;
            }
        }

        public DateTime FechaDeValor
        {
            get
            {
                return losDatos.FechaActual;
            }
        }

        public DateTime FechaDeVencimiento
        {
            get
            {
                return losDatos.FechaDeVencimiento;
            }
        }
    }
}