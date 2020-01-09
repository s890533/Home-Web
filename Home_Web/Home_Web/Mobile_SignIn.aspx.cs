using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Home_Web
{
    public partial class Mobile_SignIn : System.Web.UI.Page
    {
        string strConn1 = "server=tcp:HOMEIOT-SERVER,65535;database=IOT;User ID=";
        string strConn2 = ";Password=";
        string strConn3 = ";";
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

            if(Button_LogIn.Text == "Log In")
            {
                Panel_A.Enabled = false;
                Panel_B.Enabled = false;
                Panel_C.Enabled = false;
                Panel_D.Enabled = false;
                Panel_ON.Enabled = false;
                Panel_OFF.Enabled = false;

            }
            else
            {
                Panel_A.Enabled = true;
                Panel_B.Enabled = true;
                Panel_C.Enabled = true;
                Panel_D.Enabled = true;
                Panel_ON.Enabled = true;
                Panel_OFF.Enabled = true;
            }
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
                            Panel_A.Enabled = true;
                            Panel_B.Enabled = true;
                            Panel_C.Enabled = true;
                            Panel_D.Enabled = true;
                            Panel_ON.Enabled = true;
                            Panel_OFF.Enabled = true;
                            Button_LogIn.CssClass = "btn btn-warning";
                            Button_LogIn.Text = "Log Out";
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
                Panel_A.Enabled = false;
                Panel_B.Enabled = false;
                Panel_C.Enabled = false;
                Panel_D.Enabled = false;
                Panel_ON.Enabled = false;
                Panel_OFF.Enabled = false;
                TextBox_PW.Text = "";
                Button_LogIn.CssClass = "btn btn-primary";
                Button_LogIn.Text = "Log In";
                Panel_Content.Controls.Clear();
            }
        }

        protected void Button_Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Mobile_Main.aspx");
        }


        protected void Button_A_Click(object sender, EventArgs e)
        {
            String SQLCommand = "INSERT INTO DH_Table (update_time,target_number,target_action,IsActive) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','1','SWITCH','false');";

            if (SQL_Send(SQLCommand, TextBox_ID.Text, TextBox_PW.Text))
            {

            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('指令傳送失敗!');</script>");
            }
        }

        protected void Button_B_Click(object sender, EventArgs e)
        {
            String SQLCommand = "INSERT INTO DH_Table (update_time,target_number,target_action,IsActive) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','2','SWITCH','false');";

            if (SQL_Send(SQLCommand, TextBox_ID.Text, TextBox_PW.Text))
            {

            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('指令傳送失敗!');</script>");
            }
        }

        protected void Button_C_Click(object sender, EventArgs e)
        {
            String SQLCommand = "INSERT INTO DH_Table (update_time,target_number,target_action,IsActive) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','3','SWITCH','false');";

            if (SQL_Send(SQLCommand, TextBox_ID.Text, TextBox_PW.Text))
            {

            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('指令傳送失敗!');</script>");
            }
        }

        protected void Button_D_Click(object sender, EventArgs e)
        {
            String SQLCommand = "INSERT INTO DH_Table (update_time,target_number,target_action,IsActive) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','4','SWITCH','false');";

            if (SQL_Send(SQLCommand, TextBox_ID.Text, TextBox_PW.Text))
            {

            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('指令傳送失敗!');</script>");
            }
        }

        protected void Button_ON_Click(object sender, EventArgs e)
        {
            String SQLCommand = "INSERT INTO DH_Table (update_time,target_number,target_action,IsActive) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','1','ON','false');INSERT INTO DH_Table (update_time,target_number,target_action,IsActive) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','2','ON','false');INSERT INTO DH_Table (update_time,target_number,target_action,IsActive) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','3','ON','false');INSERT INTO DH_Table (update_time,target_number,target_action,IsActive) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','4','ON','false');";

            if (SQL_Send(SQLCommand, TextBox_ID.Text, TextBox_PW.Text))
            {

            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('指令傳送失敗!');</script>");
            }
        }

        protected void Button_OFF_Click(object sender, EventArgs e)
        {
            String SQLCommand = "INSERT INTO DH_Table (update_time,target_number,target_action,IsActive) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','1','OFF','false');INSERT INTO DH_Table (update_time,target_number,target_action,IsActive) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','2','OFF','false');INSERT INTO DH_Table (update_time,target_number,target_action,IsActive) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','3','OFF','false');INSERT INTO DH_Table (update_time,target_number,target_action,IsActive) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','4','OFF','false');";

            if (SQL_Send(SQLCommand, TextBox_ID.Text, TextBox_PW.Text))
            {

            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('指令傳送失敗!');</script>");
            }
        }
        #endregion
    }
}