using jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo;

namespace Inversiones.DS.GenerarInversion.ConPolimorfismo
{
    class InversionConTratamientoFiscal : DatosParaLaFecha
    {
        public override DatosParaLaInversion TipoDeDatos
        {
            get
            {
                return new DatosParaLaInversionConTratamiento();
            }
        }
    }
}
