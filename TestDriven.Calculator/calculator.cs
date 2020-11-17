using CalculatorInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDriven.Calculator
{
    public class calculator : ISimpleCalculator
    {

        public calculator()

        {

         //   m_total = 0.0;

        }



        //private double m_total;



        #region ICalculator Members



        //public double Total

        //{

        //    get { return m_total; }

        //}
        public int Add(int start, int amount)
        {

          throw new NotImplementedException();
        }

        public int Divide(int start, int by)
        {
            throw new NotImplementedException();
        }

        public int Multiply(int start, int by)
        {
            throw new NotImplementedException();
        }

        public int Subtract(int start, int amount)
        {
            //throw new Exception("The method or operation is not implemented.");
            throw new NotImplementedException();
        }
        #endregion
    }
}
