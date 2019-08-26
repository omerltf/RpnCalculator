using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator
{
    public class SquareRootOperation : IOperation
    {
        public void Operate(Stack<decimal> myStack)
        {
            myStack.Push((decimal)Math.Sqrt((double)myStack.Pop()));
        }
    }
}