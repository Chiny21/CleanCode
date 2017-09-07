using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jcamposc889.Negocio.CodigosDeReferencia.ConObjetos;

namespace jcamposc889.Negocio.CodigosDeReferencia.UnitTests.ConObjetos
{
    [TestClass]
    public class Requerimietno_ComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void ComoTexto_FechaNumeroDelClienteSistemaYConsecutivo_RequerimientoComoTexto()
        {
            elResultadoEsperado = "2000111133322888888888888";

            DateTime laFecha = new DateTime(2000,11,11);
            string numeroDelCliente = "333";
            string numeroDelSistema = "22";
            string numeroConsecutivo = "888888888888";

            elResultadoObtenido = new Requerimiento(laFecha, numeroDelCliente, 
                numeroDelSistema, numeroConsecutivo).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
