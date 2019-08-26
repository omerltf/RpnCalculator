using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator
{   [Serializable]
    public class Calculator
    {
        protected Stack<decimal?> myStack = new Stack<decimal?>();

        public void addToStack (decimal number)
        {
            this.myStack.Push(number);
        }

        public string[] getFromStack()
        {
            string[] myStrings = new string[4];
            for (int count=0; count<4; count++)
            {
                if (count>=myStack.Count)
                {
                    myStrings[count] = string.Empty;
                }
                else
                {
                    myStrings[count] = myStack.ElementAt(count).ToString();
                }
            }
            return myStrings;
        }

    }
}