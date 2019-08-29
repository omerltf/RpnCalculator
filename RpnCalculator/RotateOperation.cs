using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator
{
    public class RotateOperation : IOperation
    {
        public void Operate(Stack<decimal> myStack)
        {
            decimal AOperand = myStack.Pop();
            decimal BOperand = myStack.Pop();
            decimal COperand = myStack.Pop();
            myStack.Push(AOperand);
            myStack.Push(COperand);
            myStack.Push(BOperand);
        }
    }
}