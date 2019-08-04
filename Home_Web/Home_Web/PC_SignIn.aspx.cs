﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Home_Web
{
    public partial class PC_SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Url.AbsoluteUri.IndexOf("?") >= 0)
            {
                if (Request.Url.Query.IndexOf("User=") >= 0)
                {
                    TextBox_ID.Text = Request.QueryString["User"];
                    TextBox_ID.ReadOnly = true;
                    TextBox_PW.Focus();
                }
            }
            else
            {
                TextBox_ID.Focus();
            }
        }

        protected void Button_LogIn_Click(object sender, EventArgs e)
        {
            if(Button_LogIn.Text == "Log In")
            {
                if (!String.IsNullOrEmpty(TextBox_ID.Text))
                {
                    if (!String.IsNullOrEmpty(TextBox_PW.Text))
                    {
                        TextBox_ID.ReadOnly = true;
                        TextBox_PW.ReadOnly = true;
                        Button_LogIn.CssClass = "btn btn-warning";
                        Button_LogIn.Text = "Log Out";
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('請輸入密碼!');</script>");
                        TextBox_PW.Focus();
                    }
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('請輸入ID!');</script>");
                    TextBox_ID.Focus();
                }
            }
            else
            {
                if (Request.Url.AbsoluteUri.IndexOf("?") >= 0)
                {
                    if (Request.Url.Query.IndexOf("User=") >= 0)
                    {
                        TextBox_ID.Text = Request.QueryString["User"];
                        TextBox_ID.ReadOnly = true;
                    }
                    else
                    {
                        TextBox_ID.ReadOnly = false;
                    }
                }
                else
                {
                    TextBox_ID.ReadOnly = false;
                }
                TextBox_PW.ReadOnly = false;
                TextBox_PW.Text = "";
                Button_LogIn.CssClass = "btn btn-primary";
                Button_LogIn.Text = "Log In";
                Panel_Content.Controls.Clear();
            }
            
        }

        protected void Button_Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PC_Main.aspx");
        }
    }
}