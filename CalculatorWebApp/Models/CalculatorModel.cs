using System;
using System.ComponentModel.DataAnnotations;
namespace CalculatorWebApp.Models
{
    public class CalculatorModel
    {
        [Display(Name = "First Number")]
        public double x { get; set; }

        [Display(Name = "Second Number")]
        public double y { get; set; }

        [Display(Name = "Result")]
        public double result { get; set; }

        [Display(Name = "Operation")]
        public OperationType OperationType { get; set; }

        public void Add()
        {
            this.result = x + y;
        }

        public void Subtract()
        {
            this.result = x - y;
        }

        public void Multiply()
        {
            this.result = x * y;
        }

        public void Divide()
        {
            try
            {
                this.result = x / y;
            }
            catch (DivideByZeroException)
            {
                throw;
            }
        }
    }
    public enum OperationType
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }
}
