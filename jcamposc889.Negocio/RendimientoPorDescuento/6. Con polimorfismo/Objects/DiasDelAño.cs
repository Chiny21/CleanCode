using System;

namespace jcamposc889.Negocio.RendimientoPorDescuento.ConPolimorfismo
{
    public class DiasDelAño
    {
        private int elAño;

        public DiasDelAño(DatosDeInversion losDatos)
        {
            elAño = losDatos.Año;
        }

        public int ComoNumero()
        {
            if (DateTime.IsLeapYear(elAño))
                return 366;
            else
                return 365;
        }
    }
}
