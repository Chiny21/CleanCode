using System;

namespace jcamposc889.Negocio.CodigosDeReferencia.ConObjetos
{
    public class Año
    {
        private int elAño;

        public Año(DateTime laFecha)
        {
            elAño = ExtraigaElAñoDeLaFecha(laFecha);
        }

        private int ExtraigaElAñoDeLaFecha(DateTime laFecha)
        {
            return laFecha.Year;
        }

        public string ComoTexto()
        {
            return GenereElAñoComoTexto(elAño);
        }

        private string GenereElAñoComoTexto(int elAño)
        {
            return elAño.ToString();
        }
    }
}
