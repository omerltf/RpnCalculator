using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator
{
    public class NegateOperation : IOperation
    {
        public void Operate(Stack<decimal> myStack)
        {
            myStack.Push(myStack.Pop()*(-1));
        }
    }
}