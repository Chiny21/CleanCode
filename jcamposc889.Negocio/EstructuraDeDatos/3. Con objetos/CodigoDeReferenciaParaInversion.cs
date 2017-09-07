using jcamposc889.Negocio.CodigosDeReferencia.ConTellDontAsk;
using System;

namespace jcamposc889.Negocio.EstructuraDeDatos.ConObjetos
{
    public class CodigoDeReferenciaParaInversion
    {
        DatosParaElRequerimiento losDatosParaElRequerimiento;

        public CodigoDeReferenciaParaInversion(DateTime laFechaActual, string elConsecutivoParaElCodigoDeReferencia)
        {
            losDatosParaElRequerimiento = AsigneLosDatosParaElRequerimiento(laFechaActual, elConsecutivoParaElCodigoDeReferencia);
        }

        private DatosParaElRequerimiento AsigneLosDatosParaElRequerimiento(DateTime laFechaActual, string elConsecutivoParaElCodigoDeReferencia)
        {
            DatosParaElRequerimiento losDatosParaElRequerimiento = new DatosParaElRequerimiento();

            losDatosParaElRequerimiento.Fecha = laFechaActual;
            losDatosParaElRequerimiento.NumeroDelCliente = "22";
            losDatosParaElRequerimiento.NumeroDelSistema = "5";
            losDatosParaElRequerimiento.NumeroConsecutivo = elConsecutivoParaElCodigoDeReferencia;

            return losDatosParaElRequerimiento;
        }

        public string ComoTexto()
        {
            return new CodigoDeReferencia(losDatosParaElRequerimiento).ComoTexto();
        }
    }
}
