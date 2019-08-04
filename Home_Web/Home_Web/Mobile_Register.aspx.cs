using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Home_Web
{
    public partial class Mobile_Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Mobile_Main.aspx");
        }

        protected void Button_LogIn_Click(object sender, EventArgs e)
        {
            Panel_Register.Enabled = true;
        }

        protected void Button_Submit_Click(object sender, EventArgs e)
        {

        }
    }
}