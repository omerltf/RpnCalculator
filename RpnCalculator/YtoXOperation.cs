using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator
{
    public class YtoXOperation : IOperation
    {
        public void Operate(Stack<decimal> myStack)
        {
            decimal rightOperand = myStack.Pop();
            decimal leftOperand = myStack.Pop();
            try
            {
                myStack.Push((decimal)Math.Pow((double)leftOperand, (double)rightOperand));
            }
            catch (OverflowException)
            {

            }
        }
    }
}