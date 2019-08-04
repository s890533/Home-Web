using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Home_Web
{
    public partial class PC_Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //Button_Submit.Attributes.Add("disabled", "this.disabled=true;");
        }

        protected void Button_Back_Click(object sender, EventArgs e)
        {
            //Button_Submit.Attributes.Remove("disabled");
            //Button_Submit.Attributes.Add("disabled", "this.disabled=false;");
            Response.Redirect("~/PC_Main.aspx");
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