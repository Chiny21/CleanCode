using jcamposc889.Negocio.EstructuraDeDatos.ConPolimorfismo;

namespace Inversiones.DS.GenerarInversion.ConPolimorfismo
{
    public abstract class DatosParaLaInversionFinal
    {
        public double ValorFacial { get; set; }
        public double ValorTransadoNeto { get; set; }
        public int PlazoEnDias { get; set; }
        public TipoDeInversion TipoDeInversion { get; set; }

        public abstract DatosParaLaInversion TipoDeDatos { get; }
    }
}
