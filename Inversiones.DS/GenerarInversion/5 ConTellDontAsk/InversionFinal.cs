using jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo;

namespace Inversiones.DS.GenerarInversion.ConTellDontAsk
{
    public class InversionFinal
    {
        private DatosParaLaInversion losDatos;

        public InversionFinal(DatosParaLaInversionFinal losDatosFinales)
        {
            losDatos = ObtengaLosDatos(losDatosFinales);
        }

        private DatosParaLaInversion ObtengaLosDatos(DatosParaLaInversionFinal losDatosFinales)
        {
            DatosParaLaInversion losDatos = losDatosFinales.TipoDeDatos;

            DatosParaLaFecha losDatosParaLaFecha = new DatosParaLaFecha();
            losDatosParaLaFecha.PlazoEnDias = losDatosFinales.PlazoEnDias;

            losDatos.ValorFacial = losDatosFinales.ValorFacial;
            losDatos.ValorTransadoNeto = losDatosFinales.ValorTransadoNeto;
            losDatos.TasaDeImpuesto = losDatosParaLaFecha.TasaDeImpuesto;
            losDatos.FechaActual = losDatosParaLaFecha.FechaActual;
            losDatos.FechaDeVencimiento = losDatosParaLaFecha.FechaDeVencimiento;
            losDatos.ConsecutivoParaElCodigoDeReferencia = losDatosParaLaFecha.ConsecutivoComoTexto;

            return losDatos;
        }

        public Inversion ComoDatos()
        {
            return new Inversion(losDatos);
        }
    }
}
