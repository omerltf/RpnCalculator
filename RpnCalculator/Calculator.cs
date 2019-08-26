using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator
{
    [Serializable]
    public class Calculator
    {
        protected Stack<decimal> myStack = new Stack<decimal>();


        public void addToStack(decimal number)
        {
            this.myStack.Push(number);
        }


        public string[] getFromStack()
        {
            string[] myStrings = new string[4];
            for (int count = 0; count < 4; count++)
            {
                if (count >= myStack.Count)
                {
                    myStrings[count] = string.Empty;
                }
                else
                {
                    myStrings[count] = myStack.ElementAt(count).ToString();
                }
            }
            Array.Reverse(myStrings);
            return myStrings;
        }

        public void PerformOperation(OperationType operationType)
        {
            IOperation operation = null;
            if (myStack.Count >= 3)
            {
                if (operationType == OperationType.Rotate)
                {
                    operation = new RotateOperation();
                }
            }

            if (myStack.Count >= 2)
            {
                switch (operationType)
                {
                    case OperationType.Add:
                        operation = new AddOperation();
                        break;

                    case OperationType.Minus:
                        operation = new MinusOperation();
                        break;

                    case OperationType.Divide:
                        operation = new DivideOperation();
                        break;
                    case OperationType.Multiply:
                        operation = new MultiplyOperation();
                        break;
                    case OperationType.YtoX:
                        operation = new YtoXOperation();
                        break;
                    case OperationType.Swap:
                        operation = new SwapOperation();
                        break;
                }
            }
            if (myStack.Count >= 1)
            {
                switch (operationType)
                {
                    case OperationType.Negate:
                        operation = new NegateOperation();
                        break;

                    case OperationType.CosX:
                        operation = new CosXOperation();
                        break;

                    case OperationType.SinX:
                        operation = new SinXOperation();
                        break;
                    case OperationType.EtoX:
                        operation = new EtoXOperation();
                        break;
                    case OperationType.Reciprocal:
                        operation = new ReciprocalOperation();
                        break;
                    case OperationType.SquareRoot:
                        operation = new SquareRootOperation();
                        break;
                    case OperationType.Drop:
                        operation = new DropOperation();
                        break;
                    case OperationType.Clear:
                        operation = new ClearOperation();
                        break;
                }
            }

            if (operation != null)
            {
                try
                {
                    operation.Operate(myStack);
                }
                catch (OverflowException)
                {

                }
            }
        }
    }
}