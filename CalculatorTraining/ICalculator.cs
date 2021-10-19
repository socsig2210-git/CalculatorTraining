using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTraining
{
    public interface ICalculator
    {
        float Add(float x, float y);
        float Divide(float x, float y);
        float Multiply(float x, float y);
        float Subtract(float x, float y);
    }
}
