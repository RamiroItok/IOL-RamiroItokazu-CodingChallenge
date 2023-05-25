using CodingChallenge.Data.Classes.Formas;
using CodingChallenge.Data.Classes.Lenguajes;
using CodingChallenge.Data.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Reportes
{
    public abstract class Reporte
    {
        public abstract string Imprimir(List<FormaGeometrica> formas, Tuple<int, string, string> idioma);

        public ResultadoReporte CalcularFormas(List<FormaGeometrica> formas)
        {
            ResultadoReporte resultado = new ResultadoReporte();

            for (var i = 0; i < formas.Count; i++)
            {               
                if (formas[i].GetType() == typeof(Cuadrado))
                {
                    resultado.TotalFormas++;
                    resultado.NumeroCuadrados++;
                    resultado.AreaCuadrados += formas[i].CalcularArea();
                    resultado.PerimetroCuadrados += formas[i].CalcularPerimetro();
                }
                else if (formas[i].GetType() == typeof(Circulo))
                {
                    resultado.TotalFormas++;
                    resultado.NumeroCirculos++;
                    resultado.AreaCirculos += formas[i].CalcularArea();
                    resultado.PerimetroCirculos += formas[i].CalcularPerimetro();
                }
                else if (formas[i].GetType() == typeof(TrianguloEquilatero))
                {
                    resultado.TotalFormas++;
                    resultado.NumeroTriangulos++;
                    resultado.AreaTriangulos += formas[i].CalcularArea();
                    resultado.PerimetroTriangulos += formas[i].CalcularPerimetro();
                }
                else if (formas[i].GetType() == typeof(Trapecio))
                {
                    resultado.TotalFormas++;
                    resultado.NumeroTrapecios++;
                    resultado.AreaTrapecios += formas[i].CalcularArea();
                    resultado.PerimetroTrapecios += formas[i].CalcularPerimetro();
                }
            }

            resultado.AreaTotal = resultado.AreaCuadrados + resultado.AreaCirculos + resultado.AreaTriangulos + resultado.AreaTrapecios;
            resultado.PerimetroTotal = resultado.PerimetroCuadrados + resultado.PerimetroCirculos + resultado.PerimetroTriangulos + resultado.PerimetroTrapecios;

            return resultado;
        }
    }
}
