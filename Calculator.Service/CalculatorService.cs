using CalculatorInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Service
{
    public class CalculatorService : ISimpleCalculator
    {
        private int result;
        public int Add(int num1, int num2)
        {
            result = num1 + num2;
            Console.WriteLine("ICalculator  Add " + num1 + " + " + num2 + "= " + result);
            return result;
        }

        public int Divide(int num1, int num2)
        {
            result = num1 / num2;
            Console.WriteLine("ICalculator  Divide " + num1 + " / " + num2 + "= " + result);
            return result;
        }

        public int Multiply(int num1, int num2)
        {
            result = num1 * num2;
            Console.WriteLine("ICalculator  Multiply " + num1 + " * " + num2 + "= " + result);
            return result;
        }

        public int Subtract(int num1, int num2)
        {
            result = num1 - num2;
            Console.WriteLine("ICalculator  Subtraction " + num1 + " - " + num2 + "= " + result);
            return result;
        }
    }
}
