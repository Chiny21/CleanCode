using System;

namespace jcamposc889.Negocio.CodigosDeReferencia.ConParameterObject
{
    public class DatosParaElRequerimiento
    {
        public DateTime Fecha { get; set; }
        public string NumeroDelCliente { get; set; }
        public string NumeroDelSistema { get; set; }
        public string NumeroConsecutivo { get; set; } 
    }
}
