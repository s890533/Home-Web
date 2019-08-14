using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Home_Web
{
    public partial class Mobile_Register : System.Web.UI.Page
    {
        string strConn1 = "server=tcp:HOMEIOT-SERVER,65535;database=IOT;User ID=";
        string strConn2 = ";Password=";
        string strConn3 = ";";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #region SQL
        private bool SQL_TryConnect()
        {
            bool ans = false;
            SqlConnection SQL = new SqlConnection(strConn1 + TextBox_ID.Text + strConn2 + TextBox_PW.Text + strConn3);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL;
            try
            {
                SQL.Open();
                ans = true;
            }
            catch
            {
                ans = false;
            }

            return ans;
        }

        private bool SQL_CheckSQL(String Command, String ID, String PW)
        {
            bool ans = false;

            SqlConnection sql = new SqlConnection(strConn1 + ID + strConn2 + PW + strConn3);

            sql.Open();

            SqlCommand sqlcmd = new SqlCommand();

            sqlcmd.Connection = sql;

            sqlcmd.CommandText = Command;

            SqlDataReader sqlreader = sqlcmd.ExecuteReader();

            if (sqlreader.HasRows)
            {
                ans = true;
            }

            sqlcmd.Dispose();

            sql.Dispose();//Disconnect SQL


            return ans;
        }

        private bool SQL_Send(String Command, String ID, String PW)
        {
            bool ans = false;
            try
            {
                SqlConnection sql = new SqlConnection(strConn1 + TextBox_ID.Text + strConn2 + TextBox_PW.Text + strConn3);

                Console.WriteLine(Command);

                sql.Open();

                SqlCommand sqlcmd1 = new SqlCommand();

                sqlcmd1.Connection = sql;

                sqlcmd1.CommandText = Command;

                sqlcmd1.ExecuteNonQuery();

                sqlcmd1.Dispose();

                sql.Dispose();//Disconnect SQL

                ans = true;
            }
            catch
            {
                ans = false;
            }

            return ans;
        }
        #endregion

        #region KEYs
        protected void Button_Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Mobile_Main.aspx");
        }

        protected void Button_LogIn_Click(object sender, EventArgs e)
        {
            if (Button_LogIn.Text == "Log In")
            {
                if (!String.IsNullOrEmpty(TextBox_ID.Text))
                {
                    if (!String.IsNullOrEmpty(TextBox_PW.Text))
                    {
                        if (SQL_TryConnect())
                        {
                            TextBox_ID.ReadOnly = true;
                            TextBox_PW.ReadOnly = true;
                            Button_LogIn.CssClass = "btn btn-warning";
                            Button_LogIn.Text = "Log Out";
                            Panel_Register.Enabled = true;
                        }
                        else
                        {
                            ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('登入失敗!');</script>");
                        }
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
                Panel_Register.Enabled = false;
            }
        }

        protected void Button_Submit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TextBox_Server.Text))
            {
                if (!String.IsNullOrEmpty(TextBox_Client.Text))
                {
                    if (!String.IsNullOrEmpty(DropDownList_ClientType.Text))
                    {
                        if (!SQL_CheckSQL("SELECT * FROM UnitTable WHERE Owner = '" + TextBox_ID.Text + "' AND Server = '" + TextBox_Server.Text + "' AND Client = '" + TextBox_Client.Text + "';", TextBox_ID.Text, TextBox_PW.Text))
                        {
                            bool ans = SQL_Send("INSERT INTO UnitTable (Owner,Server,Client,Type) VALUES ('" + TextBox_ID.Text + "','" + TextBox_Server.Text + "','" + TextBox_Client.Text + "','" + DropDownList_ClientType.Text + "');", TextBox_ID.Text, TextBox_PW.Text);
                            if (ans)
                            {
                                ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('註冊成功!');</script>");
                                TextBox_Server.Text = "";
                                TextBox_Client.Text = "";
                            }
                            else
                            {
                                ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('註冊失敗!');</script>");
                            }
                        }
                        else
                        {
                            ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('此關聯已註冊!');</script>");
                        }
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('請選擇Server類型!');</script>");
                        DropDownList_ClientType.Focus();
                    }
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('請輸入Client ID!');</script>");
                    TextBox_Client.Focus();
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('請輸入Server ID!');</script>");
                TextBox_Server.Focus();
            }
        }
        #endregion
    }
}