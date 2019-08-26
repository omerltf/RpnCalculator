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
        public Calculator myCalculator { get
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
            } }

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

        }

        protected void HandleMinus(object sender, EventArgs e)
        {

        }

        protected void HandleMultiply(object sender, EventArgs e)
        {

        }

        protected void HandleDivide(object sender, EventArgs e)
        {

        }

        protected void HandleNegate(object sender, EventArgs e)
        {

        }

        protected void HandleDrop(object sender, EventArgs e)
        {

        }

        protected void HandleSquareRoot(object sender, EventArgs e)
        {

        }

        protected void HandleEtoX(object sender, EventArgs e)
        {

        }

        protected void HandleYtoX(object sender, EventArgs e)
        {

        }

        protected void HandleReciprocal(object sender, EventArgs e)
        {

        }

        protected void HandleSinX(object sender, EventArgs e)
        {

        }

        protected void HandleCosX(object sender, EventArgs e)
        {

        }

        protected void HandleClear(object sender, EventArgs e)
        {

        }

        protected void HandleSwap(object sender, EventArgs e)
        {

        }

        protected void HandleRotate(object sender, EventArgs e)
        {

        }
    }
}