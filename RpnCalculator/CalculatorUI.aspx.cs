using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RpnCalculator
{
    public partial class CalculatorUI : System.Web.UI.Page
    {
        public Calculator myCalculator
        {
            get
            {
                object o = ViewState["Calculator"];
                if (o != null)
                {
                    return (Calculator)o;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                ViewState["Calculator"] = value;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            if (!IsPostBack)
            {
                myCalculator = new Calculator();
            }
            base.OnLoad(e);
        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPreRenderComplete(EventArgs e)
        {
            base.OnPreRenderComplete(e);
            StackViewer.DataSource = myCalculator.getFromStack();
            StackViewer.DataBind();
        }

        protected void HandleEnter(object sender, EventArgs e)
        {
            decimal output;
            decimal.TryParse(NumberInput.Text, out output);
            myCalculator.addToStack(output);
            NumberInput.Text = "";
        }

        protected void HandleAdd(object sender, EventArgs e)
        {
            myCalculator.PerformOperation(OperationType.Add);
        }

        protected void HandleMinus(object sender, EventArgs e)
        {
            myCalculator.PerformOperation(OperationType.Minus);
        }

        protected void HandleMultiply(object sender, EventArgs e)
        {
            myCalculator.PerformOperation(OperationType.Multiply);
        }

        protected void HandleDivide(object sender, EventArgs e)
        {
            myCalculator.PerformOperation(OperationType.Divide);
        }

        protected void HandleNegate(object sender, EventArgs e)
        {
            myCalculator.PerformOperation(OperationType.Negate);
        }

        protected void HandleDrop(object sender, EventArgs e)
        {
            myCalculator.PerformOperation(OperationType.Drop);
        }

        protected void HandleSquareRoot(object sender, EventArgs e)
        {
            myCalculator.PerformOperation(OperationType.SquareRoot);
        }

        protected void HandleEtoX(object sender, EventArgs e)
        {
            myCalculator.PerformOperation(OperationType.EtoX);
        }

        protected void HandleYtoX(object sender, EventArgs e)
        {
            myCalculator.PerformOperation(OperationType.YtoX);
        }

        protected void HandleReciprocal(object sender, EventArgs e)
        {
            myCalculator.PerformOperation(OperationType.Reciprocal);
        }

        protected void HandleSinX(object sender, EventArgs e)
        {
            myCalculator.PerformOperation(OperationType.SinX);
        }

        protected void HandleCosX(object sender, EventArgs e)
        {
            myCalculator.PerformOperation(OperationType.CosX);
        }

        protected void HandleClear(object sender, EventArgs e)
        {
            myCalculator.PerformOperation(OperationType.Clear);
        }

        protected void HandleSwap(object sender, EventArgs e)
        {
            myCalculator.PerformOperation(OperationType.Swap);
        }

        protected void HandleRotate(object sender, EventArgs e)
        {
            myCalculator.PerformOperation(OperationType.Rotate);
        }
    }
}