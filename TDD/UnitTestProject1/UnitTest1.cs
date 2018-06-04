using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ObtenerPersistencia_UnDigito_Cero()
        {
            long numeroPrueba = 2;
            int esperado = 0;
            var persistencia = new Prueba.CalculaPersistencia();
            var resultado = persistencia.Calcula(numeroPrueba);

            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void ObtenerPersistencia_DosDigitos_Uno()
        {
            long numeroPrueba = 23;
            int esperado = 1;
            var persistencia = new Prueba.CalculaPersistencia();
            var resultado = persistencia.Calcula(numeroPrueba);

            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void ObtenerPersistencia_TresDigitos_Uno()
        {
            long numeroPrueba = 123;
            int esperado = 2;
            var persistencia = new Prueba.CalculaPersistencia();
            var resultado = persistencia.Calcula(numeroPrueba);

            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void ObtenerPersistencia_TresDigitos_Dos()
        {
            long numeroPrueba = 1234;
            int esperado = 2;
            var persistencia = new Prueba.CalculaPersistencia();
            var resultado = persistencia.Calcula(numeroPrueba);

            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void ObtenerPersistencia_CincoDigitos12345_Dos()
        {
            long numeroPrueba = 12345;
            int esperado = 2;
            var persistencia = new Prueba.CalculaPersistencia();
            var resultado = persistencia.Calcula(numeroPrueba);

            Assert.AreEqual(resultado, esperado, "12345 = 120 que equivale a 2 veces");
        }

        [TestMethod]
        public void ObtenerPersistencia_CincoDigitos99999_Dos()
        {
            long numeroPrueba = 99999;
            int esperado = 2;
            var persistencia = new Prueba.CalculaPersistencia();
            var resultado = persistencia.Calcula(numeroPrueba);

            Assert.AreEqual(resultado, esperado, numeroPrueba +" = que equivale a 2 veces");
        }

        [TestMethod]
        public void ObtenerPersistencia_CincoDigitos77777_Dos()
        {
            long numeroPrueba = 77777;
            int esperado = 2;
            var persistencia = new Prueba.CalculaPersistencia();
            var resultado = persistencia.Calcula(numeroPrueba);

            Assert.AreEqual(resultado, esperado, numeroPrueba + " = que equivale a 2 veces");
        }
    }
}
