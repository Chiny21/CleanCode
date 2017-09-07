using System;

namespace jcamposc889.Negocio.Validacion.ConParameterObject
{
    public class DatosParaVerificar
    {
        public double elValorFacial { get; set; }
        public double elValorTransadoNeto { get; set; }
        public double laTasaDeImpuesto{ get; set; }
        public DateTime laFechaActual { get; set; }
        public DateTime laFechaDeVencimiento { get; set; }
    }
}
