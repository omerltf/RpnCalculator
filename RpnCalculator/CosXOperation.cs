using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator
{
    public class CosXOperation : IOperation
    {
        public void Operate(Stack<decimal> myStack)
        {
            myStack.Push((decimal)Math.Sin((Math.PI * (double)myStack.Pop()) / 180.0));
        }
    }
}