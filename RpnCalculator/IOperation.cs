﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnCalculator
{
    interface IOperation
    {
        void Operate(Stack<decimal> myStack);
    }
}
