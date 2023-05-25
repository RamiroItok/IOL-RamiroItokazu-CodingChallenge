using CodingChallenge.Data.Classes.Formas;
using CodingChallenge.Data.Classes.Lenguajes;
using CodingChallenge.Data.Classes.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Reportes
{
    public class Generador : Reporte
    {
        public override string Imprimir(List<FormaGeometrica> formas, Tuple<int, string, string> idioma)
        {
            var sb = new StringBuilder();

            #region Idioma del Reporte
            if(idioma == null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("es-AR");
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("es-AR");
            }
            else
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(idioma.Item2);
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(idioma.Item2);
            }
            
            #endregion

            if (!formas.Any())
            {
                sb.Append($"<h1>{Resource.FormaVacia}</h1>");
            }
            else
            {
                sb.Append($"<h1>{ Resource.Titulo}</h1>");

                ResultadoReporte resultado = CalcularFormas(formas);

                if (resultado.NumeroCuadrados > 0)
                {
                    sb.Append($"{ObtenerLinea("Cuadrado", resultado.NumeroCuadrados)} | {Resource.Area} {resultado.AreaCuadrados:#.##} | {Resource.Perimetro} {resultado.PerimetroCuadrados:#.##} <br/>");
                }
                                
                if (resultado.NumeroCirculos > 0)
                {
                    sb.Append($"{ObtenerLinea("Circulo", resultado.NumeroCirculos)} | {Resource.Area} {resultado.AreaCirculos:#.##} | {Resource.Perimetro} {resultado.PerimetroCirculos:#.##} <br/>");
                }
                
                if (resultado.NumeroTriangulos > 0)
                {
                    sb.Append($"{ObtenerLinea("TrianguloEquilatero", resultado.NumeroTriangulos)} | {Resource.Area}  {resultado.AreaTriangulos:#.##}  | {Resource.Perimetro}  {resultado.PerimetroTriangulos:#.##} <br/>");
                }

                if (resultado.NumeroTrapecios > 0)
                {
                    sb.Append($"{ObtenerLinea("Trapecio", resultado.NumeroTrapecios)} | {Resource.Area}  {resultado.AreaTrapecios:#.##}  | {Resource.Perimetro}  {resultado.PerimetroTrapecios:#.##} <br/>");
                }

                #region FOOTER
                sb.Append($"{Resource.Total}:<br/>");
                sb.Append($"{resultado.TotalFormas} {Resource.Formas} ");
                sb.Append($"{Resource.Perimetro} {resultado.PerimetroTotal:#.##} ");
                sb.Append($"{Resource.Area} {resultado.AreaTotal:#.##}");
                #endregion
            }

            return sb.ToString();
        }

        private string ObtenerLinea(string forma, int cantidad)
        {
            string nombre = "";
            switch (forma){
                case "Cuadrado": nombre = $"{cantidad} {Resource.Cuadrado}";
                    break;
                case "Circulo": nombre = $"{cantidad} {Resource.Circulo}";
                    break;
                case "Trapecio": nombre = $"{cantidad} {Resource.TrapecioRectangular}";
                    break;
                default: nombre = $"{cantidad} {Resource.Formas}";
                    break;
            }

            return nombre;
        }
    }
}
