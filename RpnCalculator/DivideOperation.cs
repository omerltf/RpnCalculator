﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator
{
    public class DivideOperation : IOperation
    {
        public void Operate(Stack<decimal> myStack)
        {
            decimal rightOperand = myStack.Pop();
            decimal leftOperand = myStack.Pop();
            myStack.Push(leftOperand / rightOperand);
        }
    }
}