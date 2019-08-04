using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Home_Web
{
    public partial class Mobile_Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Url.AbsoluteUri.IndexOf("?") >= 0)
            {
                if (Request.Url.Query.IndexOf("User=") >= 0)
                {
                    Response.Redirect("~/Mobile_SignIn.aspx" + Request.Url.Query);
                }
            }
        }

        protected void LinkButton1_Click_X(object sender, EventArgs e)
        {
            Response.Redirect("~/PC_Main.aspx" + Request.Url.Query);
        }

        protected void Button_register_Click_X(object sender, EventArgs e)
        {
            Response.Redirect("~/Mobile_Register.aspx");
        }

        protected void Button_signin_Click_X(object sender, EventArgs e)
        {
            Response.Redirect("~/Mobile_SignIn.aspx");
        }

        protected void Button_manager_Click_X(object sender, EventArgs e)
        {

        }

        #region KEY
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton1_Click_X( sender,  e);
        }

        protected void Button_register_Click(object sender, EventArgs e)
        {
            Button_register_Click_X( sender,  e);
        }

        protected void Button_signin_Click(object sender, EventArgs e)
        {
            Button_signin_Click_X( sender,  e);
        }

        protected void Button_manager_Click(object sender, EventArgs e)
        {
            Button_manager_Click_X( sender,  e);
        }
        #endregion
    }
}