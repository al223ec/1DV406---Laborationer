using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IntroApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            result.Text = "sidan laddad"; 
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            int number1, number2; 

            if(!int.TryParse(op1.Text, out number1))
            {
                result.Text = "fel fält 1 innehåller inte ett tal";
                return; 
            }

            if (!int.TryParse(op2.Text, out number2))
            {
                result.Text = "fel fält 2 innehåller inte ett tal";
                return; 
            }

            result.Text = (number1 + number2).ToString();
        }
    }
}