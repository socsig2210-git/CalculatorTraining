using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTraining
{
    public class CrazyCalculator : ICalculator
    {
        public float Add(float x, float y)
        {
            return x + y + 2;
        }

        public float Divide(float x, float y)
        {
            return (x / y) + 2;
        }

        public float Multiply(float x, float y)
        {
            return (x * y) + 2;
        }

        public float Subtract(float x, float y)
        {
            return (x - y) + 2;
        }
    }
}
