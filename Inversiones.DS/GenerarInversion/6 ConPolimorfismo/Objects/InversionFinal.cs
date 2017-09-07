using jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo;

namespace Inversiones.DS.GenerarInversion.ConPolimorfismo
{
    public class InversionFinal
    {
        private DatosParaLaInversion losDatos;

        public InversionFinal(DatosParaLaFecha losDatosParaLaFecha)
        {
            losDatos = ObtengaLosDatos(losDatosParaLaFecha);
        }

        private DatosParaLaInversion ObtengaLosDatos(DatosParaLaFecha losDatosParaLaFecha)
        {
            DatosParaLaInversion losDatos = losDatosParaLaFecha.TipoDeDatos;

            losDatos.ValorFacial = losDatosParaLaFecha.ValorFacial;
            losDatos.ValorTransadoNeto = losDatosParaLaFecha.ValorTransadoNeto;
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
