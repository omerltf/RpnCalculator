using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator
{
    public class ReciprocalOperation : IOperation
    {
        public void Operate(Stack<decimal> myStack)
        {
            myStack.Push(1/myStack.Pop());
        }
    }
}