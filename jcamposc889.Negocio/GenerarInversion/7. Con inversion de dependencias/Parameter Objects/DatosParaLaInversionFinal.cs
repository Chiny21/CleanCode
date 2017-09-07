using jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo;

namespace Inversiones.Negocio.GenerarInversion.ConInversionDeDependencias
{
    public abstract class DatosParaLaInversionFinal
    {
        public double ValorFacial { get; set; }
        public double ValorTransadoNeto { get; set; }
        public int PlazoEnDias { get; set; }

        public abstract DatosParaLaInversion TipoDeDatos { get; }
    }
}
