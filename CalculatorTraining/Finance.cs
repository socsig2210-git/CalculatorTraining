using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTraining
{
    public class Finance
    {
        public ICalculator Calculator { get; }

        public Finance(ICalculator calculator)
        {
            Calculator = calculator;
        }        

        public float CustomAction(float x, float y)
        {
            var num = Calculator.Add(x * x, y * y);

            var result = num + 10;

            return result;
        }
    }
}
