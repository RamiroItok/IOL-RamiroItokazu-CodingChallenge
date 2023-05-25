using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes.Formas;
using CodingChallenge.Data.Classes.Lenguajes;
using CodingChallenge.Data.Classes.Reportes;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            var idioma = Idiomas.Lenguajes;
            var formas = new List<FormaGeometrica> { };
            //es-AR
            Generador generador = new Generador();
            var detalleFormas = generador.Imprimir(formas, idioma[0]);
            Assert.AreEqual("<h1>Lista vacía de formas</h1>", detalleFormas); 
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            var idioma = Idiomas.Lenguajes;
            var formas = new List<FormaGeometrica> { };
            //es-AR
            Generador generador = new Generador();
            var detalleFormas = generador.Imprimir(formas, idioma[1]);
            Assert.AreEqual("<h1>Empty list of shapes</h1>", detalleFormas);
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var idioma = Idiomas.Lenguajes;
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };
            //es-AR
            Generador generador = new Generador();
            var detalleFormas = generador.Imprimir(cuadrados, idioma[0]); 
            Assert.AreEqual("<h1>Reporte de formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>Total:<br/>1 Formas Perimetro 20 Area 25", detalleFormas);
        }
        
        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var idioma = Idiomas.Lenguajes;
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado (1),
                new Cuadrado(3)
            };

            Generador generador = new Generador();
            var resumen = generador.Imprimir(cuadrados, idioma[1]);

            Assert.AreEqual("<h1>Shapes report</h1>3 Square | Area 35 | Perimeter 36 <br/>Total:<br/>3 Shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTrapecios()
        {
            var idioma = Idiomas.Lenguajes;
            var trapecios = new List<FormaGeometrica>
            {
                new Trapecio(5, 3, 2, 4, 8, 2, 5),
                new Trapecio(8, 2, 3, 5, 6, 3, 4),
                new Trapecio(3, 2, 1, 5, 2, 6, 3),
            };
            Generador generador = new Generador();
            var resumen = generador.Imprimir(trapecios, idioma[3]);

            Assert.AreEqual("<h1>Rapport de formulaires</h1>3 Trapéze rectangle | Zone  58  | Périmétre  43 <br/>Total:<br/>3 Formes Périmétre 43 Zone 58", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposIngles()
        {
            var idioma = Idiomas.Lenguajes;
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };
            Generador generador = new Generador();
            var resumen = generador.Imprimir(formas, idioma[1]);

            Assert.AreEqual("<h1>Shapes report</h1>2 Square | Area 29 | Perimeter 28 <br/>2 Circle | Area 13.01 | Perimeter 18.06 <br/>3 Shapes | Area  49.64  | Perimeter  51.6 <br/>Total:<br/>7 Shapes Perimeter 97.66 Area 91.65", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var idioma = Idiomas.Lenguajes;
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };
            Generador generador = new Generador();
            var resumen = generador.Imprimir(formas, idioma[0]);

            Assert.AreEqual(
                "<h1>Reporte de formas</h1>2 Cuadrado | Area 29 | Perimetro 28 <br/>2 Circulo | Area 13,01 | Perimetro 18,06 <br/>3 Formas | Area  49,64  | Perimetro  51,6 <br/>Total:<br/>7 Formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadradosIdiomaInexistente()
        {
            var idioma = Idiomas.Lenguajes;
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            Generador generador = new Generador();

            Tuple<int, string, string> idiomaSeleccionado = null;
            if (idioma.Length > 4)
            {
                idiomaSeleccionado = idioma[4];
            }

            var resumen = generador.Imprimir(cuadrados, idiomaSeleccionado);

            Assert.AreEqual("<h1>Reporte de formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>Total:<br/>1 Formas Perimetro 20 Area 25", resumen);
        }
    }
}
