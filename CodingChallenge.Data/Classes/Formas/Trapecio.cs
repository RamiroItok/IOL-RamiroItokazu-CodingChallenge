using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Formas
{
    public class Trapecio : FormaGeometrica
    {
        private readonly decimal _lado1;
        private readonly decimal _lado2;
        private readonly decimal _lado3;
        private readonly decimal _lado4;
        private readonly decimal _altura;
        private readonly decimal _baseMayor;
        private readonly decimal _baseMenor;

        public Trapecio (decimal lado1, decimal lado2, decimal lado3, decimal lado4, decimal altura, decimal baseMayor, decimal baseMenor)
        {
            _lado1 = lado1;
            _lado2 = lado2;
            _lado3 = lado3;
            _lado4 = lado4;
            _altura = altura;
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
        }

        public override decimal CalcularArea()
        {
            return ((_baseMayor + _baseMenor) * _altura) / 2;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado1 + _lado2 + _lado3 + _lado4;
        }
    }
}
