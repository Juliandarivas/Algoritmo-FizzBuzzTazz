using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;

namespace FizzBuzzTazz.Test
{
    [TestClass]
    public class ProgramUnitTest
    {
        [TestMethod]
        public void CuandoIngresaTextoValidoEjecutaPrograma()
        {
            string[] resultadoEsperado = new string[1] { "1" };

            string textoValido = "1";
            
            string[] resultadoActual = Program.EjecutarPrograma(textoValido);

            Assert.IsTrue(resultadoEsperado.SequenceEqual(resultadoActual));
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),"El valor es inválido.")]
        public void CuandoIngresaTextoInvalidoLanzaExcepcion()
        {
            string textoValido = "Heloo222";

            Program.EjecutarPrograma(textoValido);
        }

        [TestMethod]
        public void CuandoIngresoValorCeroRetornaListaStringVacia()
        {
            int cantidad = 0;

            string[] listaActual = Program.LlenarFizzBuzzTazz(cantidad);

            Assert.IsTrue(listaActual.GetType().IsArray);
            Assert.IsTrue(listaActual.Length == 0);
        }

        [TestMethod]
        public void CuandoIngresaCantidadUnoRetornaLitaConUno()
        {
            int cantidad = 1;
            string[] listaEsperada = { "1" };

            string[] listaActual = Program.LlenarFizzBuzzTazz(cantidad);

            Assert.AreEqual(listaEsperada.Length, listaActual.Length);
            Assert.AreEqual(listaEsperada[0], listaActual[0]);
        }

        [TestMethod]
        public void CuandoIngresaCantidad2retornaListaConUnoYDos()
        {
            int cantidad = 2;
            string[] listaEsperada = { "1", "2" };

            string[] listaActual = Program.LlenarFizzBuzzTazz(cantidad);

            Assert.AreEqual(listaEsperada.Length, listaActual.Length);
            Assert.AreEqual(listaEsperada[0], listaActual[0]);
            Assert.AreEqual(listaEsperada[1], listaActual[1]);
        }

        [TestMethod]
        public void CuandoIngresoCantidadyEnListaHayMultiplosDe3retornaListaConFizz()
        {
            int cantidad = 3;
            string[] listaEsperada = { "1", "2", "Fizz" };

            string[] listaActual = Program.LlenarFizzBuzzTazz(cantidad);

            Assert.AreEqual(listaEsperada.Length, listaActual.Length);
            Assert.AreEqual(listaEsperada[0], listaActual[0]);
            Assert.AreEqual(listaEsperada[2], listaActual[2]);
        }

        [TestMethod]
        public void CuandoIngresoCantidadyEnListaHayMultiplosDe3yDe5retornaListaConFizzBuzz()
        {
            int cantidad = 5;
            string[] listaEsperada = { "1", "2", "Fizz", "4", "Buzz" };

            string[] listaActual = Program.LlenarFizzBuzzTazz(cantidad);

            Assert.AreEqual(listaEsperada.Length, listaActual.Length);
            Assert.AreEqual(listaEsperada[0], listaActual[0]);
            Assert.AreEqual(listaEsperada[2], listaActual[2]);
            Assert.AreEqual(listaEsperada[4], listaActual[4]);
        }

        [TestMethod]
        public void CuandoIngresoCantidadyEnListaHayMultiplosDe3De5YDe7retornaListaConFizzBuzzTazz()
        {
            int cantidad = 7;
            string[] listaEsperada = { "1", "2", "Fizz", "4", "Buzz", "6", "Tazz" };

            string[] listaActual = Program.LlenarFizzBuzzTazz(cantidad);

            Assert.AreEqual(listaEsperada.Length, listaActual.Length);
            Assert.AreEqual(listaEsperada[0], listaActual[0]);
            Assert.AreEqual(listaEsperada[2], listaActual[2]);
            Assert.AreEqual(listaEsperada[4], listaActual[4]);
            Assert.AreEqual(listaEsperada[6], listaActual[6]);
        }

        [TestMethod]
        public void CuandoIngresoCantidad30yEnListaHayMultiplosDe3De5YDe7retornaListaConFizzBuzzTazz()
        {
            int cantidad = 30;

            string[] listaEsperada = {
                "1", "2", "Fizz", "4", "Buzz", "Fizz", "Tazz", "8", "Fizz",
                "Buzz", "11", "Fizz", "13", "Tazz", "FizzBuzz", "16", "17", "Fizz", "19",
                "Buzz", "FizzTazz", "22", "23", "Fizz", "Buzz", "26", "Fizz", "Tazz", "29", "FizzBuzz"};

            string[] listaActual = Program.LlenarFizzBuzzTazz(cantidad);

            Assert.AreEqual(listaEsperada.Length, listaActual.Length);
            Assert.AreEqual(listaEsperada[14], listaActual[14]);
            Assert.AreEqual(listaEsperada[20], listaActual[20]);
            Assert.AreEqual(listaEsperada[29], listaActual[29]);
        }
    }
}
