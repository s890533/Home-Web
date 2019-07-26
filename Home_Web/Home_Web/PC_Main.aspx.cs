using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Home_Web
{
    public partial class PC_Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void LinkButton1_Click_X(object sender, EventArgs e)
        {
            Response.Redirect("~/Mobile_Main.aspx" + Request.Url.Query);
        }

        #region KEY
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton1_Click_X( sender,  e);
        }
        #endregion
    }
}