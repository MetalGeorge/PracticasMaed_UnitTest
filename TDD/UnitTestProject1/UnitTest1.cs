using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ObtenerPersistencia_2_0()
        {
            long numeroPrueba = 2;
            int esperado = 0;
            var persistencia = new Prueba.CalculaPersistencia();
            var resultado = persistencia.Calcula(numeroPrueba);

            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void ObtenerPersistencia_39_3()
        {
            long numeroPrueba = 39;
            int esperado = 3;
            var persistencia = new Prueba.CalculaPersistencia();
            var resultado = persistencia.Calcula(numeroPrueba);

            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void ObtenerPersistencia_59_3()
        {
            long numeroPrueba = 59;
            int esperado = 3;
            var persistencia = new Prueba.CalculaPersistencia();
            var resultado = persistencia.Calcula(numeroPrueba);

            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void ObtenerPersistencia_88_3()
        {
            long numeroPrueba = 88;
            int esperado = 3;
            var persistencia = new Prueba.CalculaPersistencia();
            var resultado = persistencia.Calcula(numeroPrueba);

            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void ObtenerPersistencia_23_1()
        {
            long numeroPrueba = 23;
            int esperado = 1;
            var persistencia = new Prueba.CalculaPersistencia();
            var resultado = persistencia.Calcula(numeroPrueba);

            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void ObtenerPersistencia_123_1()
        {
            long numeroPrueba = 123;
            int esperado = 1;
            var persistencia = new Prueba.CalculaPersistencia();
            var resultado = persistencia.Calcula(numeroPrueba);

            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void ObtenerPersistencia_1234_2()
        {
            long numeroPrueba = 1234;
            int esperado = 2;
            var persistencia = new Prueba.CalculaPersistencia();
            var resultado = persistencia.Calcula(numeroPrueba);

            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void ObtenerPersistencia_12345_2()
        {
            long numeroPrueba = 12345;
            int esperado = 2;
            var persistencia = new Prueba.CalculaPersistencia();
            var resultado = persistencia.Calcula(numeroPrueba);

            Assert.AreEqual(resultado, esperado, "12345 = 120 que equivale a 2 veces");
        }

        [TestMethod]
        public void ObtenerPersistencia_99999_2()
        {
            long numeroPrueba = 99999;
            int esperado = 2;
            var persistencia = new Prueba.CalculaPersistencia();
            var resultado = persistencia.Calcula(numeroPrueba);

            Assert.AreEqual(resultado, esperado, numeroPrueba +" = que equivale a 2 veces");
        }

        [TestMethod]
        public void ObtenerPersistencia_77777_Dos()
        {
            long numeroPrueba = 77777;
            int esperado = 2;
            var persistencia = new Prueba.CalculaPersistencia();
            var resultado = persistencia.Calcula(numeroPrueba);

            Assert.AreEqual(resultado, esperado, numeroPrueba + " = que equivale a 2 veces");
        }
    }
}
