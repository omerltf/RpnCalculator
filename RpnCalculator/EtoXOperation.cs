using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator
{
    public class EtoXOperation : IOperation
    {
        public void Operate(Stack<decimal> myStack)
        {
            try
            {
                myStack.Push((decimal)Math.Pow((double)myStack.Pop(), 2.71828));
            }
            catch (OverflowException)
            {

            }
        }
    }
}