using jcamposc889.Negocio.CodigosDeReferencia.ConTellDontAsk;
using System;

namespace jcamposc889.Negocio.EstructuraDeDatos.ConTellDontAsk
{
    public class CodigoDeReferenciaParaInversion
    {
        DatosParaElRequerimiento losDatosParaElRequerimiento;

        public CodigoDeReferenciaParaInversion(DatosParaLaInversion losDatos)
        {
            losDatosParaElRequerimiento = AsigneLosDatosParaElRequerimiento(losDatos);
        }

        private DatosParaElRequerimiento AsigneLosDatosParaElRequerimiento(DatosParaLaInversion losDatos)
        {
            DatosParaElRequerimiento losDatosParaElRequerimiento = new DatosParaElRequerimiento();
            losDatosParaElRequerimiento.Fecha = losDatos.FechaActual;
            losDatosParaElRequerimiento.NumeroDelCliente = "22";
            losDatosParaElRequerimiento.NumeroDelSistema = "5";
            losDatosParaElRequerimiento.NumeroConsecutivo = losDatos.ConsecutivoParaElCodigoDeReferencia;

            return losDatosParaElRequerimiento;
        }

        public string ComoTexto()
        {
            return new CodigoDeReferencia(losDatosParaElRequerimiento).ComoTexto();
        }
    }
}
