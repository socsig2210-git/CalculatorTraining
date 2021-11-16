using CalculatorTraining;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTraining
{
    public class Calculator: ICalculator
    {
        public float Add(float x, float y)
        {
            return x + y;
        }

        public float Subtract(float x, float y)
        {
            return x - y;
        }

        public float Multiply(float x, float y)
        {
            return x * y;
        }

        public float Divide(float x, float y)
        {
            try
            {
                return x / y;
            }
            catch (DivideByZeroException)
            {
                throw;
            }
        }
    }
}
