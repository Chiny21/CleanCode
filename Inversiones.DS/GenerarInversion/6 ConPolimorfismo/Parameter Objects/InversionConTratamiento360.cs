using jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo;

namespace Inversiones.DS.GenerarInversion.ConPolimorfismo
{
    class InversionConTratamiento360 : DatosParaLaFecha
    {
        public override DatosParaLaInversion TipoDeDatos
        {
            get
            {
                return new DatosParaLaInversion360();
            }
        }
    }
}
