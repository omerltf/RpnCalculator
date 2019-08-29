using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator
{
    public class ClearOperation : IOperation
    {
        public void Operate(Stack<decimal> myStack)
        {
            myStack.Clear();
        }
    }
}