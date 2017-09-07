using jcamposc889.Negocio.CodigosDeReferencia.ConTellDontAsk;

namespace jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo
{
    public class CodigoDeReferenciaParaInversion
    {
        DatosParaElRequerimiento losDatosParaElRequerimiento;

        public CodigoDeReferenciaParaInversion(DatosParaLaInversion losDatos)
        {
            losDatosParaElRequerimiento = new DatosParaElRequerimiento();

            losDatosParaElRequerimiento.Fecha = losDatos.FechaActual;
            losDatosParaElRequerimiento.NumeroDelCliente = losDatos.NumeroDelCliente;
            losDatosParaElRequerimiento.NumeroDelSistema = losDatos.NumeroDelSistema;
            losDatosParaElRequerimiento.NumeroConsecutivo = losDatos.ConsecutivoParaElCodigoDeReferencia;
        }

        public string ComoTexto()
        {
            return new CodigoDeReferencia(losDatosParaElRequerimiento).ComoTexto();
        }
    }
}
