using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Home_Web
{
    public partial class PC_Information : System.Web.UI.Page
    {
        string strConn1 = "server=tcp:HOMEIOT-SERVER,65535;database=IOT;User ID=";
        string strConn2 = ";Password=";
        string strConn3 = ";";
        string Update_Command = "N/A";
        SqlDataReader SQLDR;
        int nowID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel_Information.Enabled = true;
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

        private bool SQL_Download(String Command, String ID, String PW)
        {
            bool ans = false;

            try
            {
                SqlConnection sql = new SqlConnection(strConn1 + TextBox_ID.Text + strConn2 + TextBox_PW.Text + strConn3);

                sql.Open();

                SqlCommand sqlcmd = new SqlCommand();

                sqlcmd.Connection = sql;

                sqlcmd.CommandText = Command;

                SqlDataReader sqlreader = sqlcmd.ExecuteReader();

                if (sqlreader.HasRows)
                {
                    SQLDR = sqlreader;
                    ans = true;
                }
                else
                {
                    ans = false;
                }

                sqlcmd.Dispose();

                sql.Dispose();
            }
            catch
            {

            }

            return ans;
        }
        #endregion

        #region Dryer
        string Dryer_HTML_UpdateTime = "<body lang=EN-US link=\"#0563C1\" vlink=\"#954F72\"><div class=WordSection1><table class=MsoNormalTable border=1 cellspacing=0 cellpadding=0 style='border-collapse:collapse;border:none'><tr style='height:69.25pt'><td width=407 valign=top style='width:305.5pt;border:solid white 1.0pt;background:#5B9BD5;padding:0in 5.4pt 0in 5.4pt;height:69.25pt'><p class=MsoNormal align=center style='text-align:center'><span style='font-size:22.0pt;color:white'>Update Time<o:p></o:p></span></p></td><td width=111 valign=top style='width:83.35pt;border:solid white 1.0pt;border-left:none;background:#5B9BD5;padding:0in 0in 0in 0in;height:69.25pt'><p class=MsoNormal align=center style='text-align:center'><span style='font-size:22.0pt;color:white'>Power<o:p></o:p></span></p></td><td width=111 valign=top style='width:83.4pt;border:solid white 1.0pt;border-left:none;background:#5B9BD5;padding:0in 5.4pt 0in 5.4pt;height:69.25pt'><p class=MsoNormal align=center style='text-align:center'><span style='font-size:22.0pt;color:white'>Hour<o:p></o:p></span></p></td><td width=131 valign=top style='width:98.25pt;border:solid white 1.0pt;border-left:none;background:#5B9BD5;padding:0in 5.4pt 0in 5.4pt;height:69.25pt'><p class=MsoNormal align=center style='text-align:center'><span style='font-size:22.0pt;color:white'>Inside Water<o:p></o:p></span></p></td><td width=131 valign=top style='width:98.3pt;border:solid white 1.0pt;border-left:none;background:#5B9BD5;padding:0in 5.4pt 0in 5.4pt;height:69.25pt'><p class=MsoNormal align=center style='text-align:center'><span style='font-size:22.0pt;color:white'>Outside Water<o:p></o:p></span></p></td><td width=112 valign=top style='width:83.75pt;border:solid white 1.0pt;border-left:none;background:#5B9BD5;padding:0in 5.4pt 0in 5.4pt;height:69.25pt'><p class=MsoNormal align=center style='text-align:center'><span style='font-size:22.0pt;color:white'>Switch<o:p></o:p></span></p></td><td width=105 valign=top style='width:78.95pt;border:solid white 1.0pt;border-left:none;background:#5B9BD5;padding:0in 5.4pt 0in 5.4pt;height:69.25pt'><p class=MsoNormal align=center style='text-align:center'><span style='font-size:22.0pt;color:white'>Motor<o:p></o:p></span></p></td><td width=113 valign=top style='width:84.45pt;border:solid white 1.0pt;border-left:none;background:#5B9BD5;padding:0in 5.4pt 0in 5.4pt;height:69.25pt'><p class=MsoNormal align=center style='text-align:center'><span style='font-size:22.0pt;color:white'>Fan Speed<o:p></o:p></span></p></td><td width=138 valign=top style='width:103.35pt;border:solid white 1.0pt;border-left:none;background:#5B9BD5;padding:0in 5.4pt 0in 5.4pt;height:69.25pt'><p class=MsoNormal align=center style='text-align:center'><span style='font-size:22.0pt;color:white'>Humidity<o:p></o:p></span></p></td><td width=197 valign=top style='width:147.8pt;border:solid white 1.0pt;border-left:none;background:#5B9BD5;padding:0in 5.4pt 0in 5.4pt;height:69.25pt'><p class=MsoNormal align=center style='text-align:center'><span style='font-size:22.0pt;color:white'>Temperature<o:p></o:p></span></p></td></tr><tr style='height:42.55pt'><td width=407 valign=top style='width:305.5pt;border:solid white 1.0pt;border-top:none;background:#002060;padding:0in 5.4pt 0in 5.4pt;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span style='font-size:22.0pt;color:white'>";
        string Dryer_HTML_Power = "<o:p></o:p></span></p></td><td width=111 valign=top style='width:83.35pt;border-top:none;border-left:none;border-bottom:solid white 1.0pt;border-right:solid white 1.0pt;background:#002060;padding:0in 0in 0in 0in;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span style='font-size:22.0pt;color:white'>";
        string Dryer_HTML_Hour = "<o:p></o:p></span></p></td><td width=111 valign=top style='width:83.4pt;border-top:none;border-left:none;border-bottom:solid white 1.0pt;border-right:solid white 1.0pt;background:#002060;padding:0in 5.4pt 0in 5.4pt;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span style='font-size:22.0pt;color:white'>";
        string Dryer_HTML_INW = "<o:p></o:p></span></p></td><td width=131 valign=top style='width:98.25pt;border-top:none;border-left:none;border-bottom:solid white 1.0pt;border-right:solid white 1.0pt;background:#002060;padding:0in 5.4pt 0in 5.4pt;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span style='font-size:22.0pt;color:white'>";
        string Dryer_HTML_OUTW = "<o:p></o:p></span></p></td><td width=131 valign=top style='width:98.3pt;border-top:none;border-left:none;border-bottom:solid white 1.0pt;border-right:solid white 1.0pt;background:#002060;padding:0in 5.4pt 0in 5.4pt;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span style='font-size:22.0pt;color:white'>";
        string Dryer_HTML_Switch = "<o:p></o:p></span></p></td><td width=112 valign=top style='width:83.75pt;border-top:none;border-left:none;border-bottom:solid white 1.0pt;border-right:solid white 1.0pt;background:#002060;padding:0in 5.4pt 0in 5.4pt;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span style='font-size:22.0pt;color:white'>";
        string Dryer_HTML_Motor = "<o:p></o:p></span></p></td><td width=105 valign=top style='width:78.95pt;border-top:none;border-left:none;border-bottom:solid white 1.0pt;border-right:solid white 1.0pt;background:#002060;padding:0in 5.4pt 0in 5.4pt;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span style='font-size:22.0pt;color:white'>";
        string Dryer_HTML_FanSpeed = "<o:p></o:p></span></p></td><td width=113 valign=top style='width:84.45pt;border-top:none;border-left:none;border-bottom:solid white 1.0pt;border-right:solid white 1.0pt;background:#002060;padding:0in 5.4pt 0in 5.4pt;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span style='font-size:22.0pt;color:white'>";
        string Dryer_HTML_H = "<o:p></o:p></span></p></td><td width=138 valign=top style='width:103.35pt;border-top:none;border-left:none;border-bottom:solid white 1.0pt;border-right:solid white 1.0pt;background:#002060;padding:0in 5.4pt 0in 5.4pt;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span style='font-size:22.0pt;color:white'>";
        string Dryer_HTML_T = "<o:p></o:p></span></p></td><td width=197 valign=top style='width:147.8pt;border-top:none;border-left:none;border-bottom:solid white 1.0pt;border-right:solid white 1.0pt;background:#002060;padding:0in 5.4pt 0in 5.4pt;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span style='font-size:22.0pt;color:white'>";
        string Dryer_HTML_END = "<o:p></o:p></span></p></td></tr></table><p class=MsoNormal><o:p>&nbsp;</o:p></p></div></body>";
        private void Dryer_Refresh()
        {
            //if (SQL_Download("SELECT * FROM DryerTable WHERE MAX (ID);", TextBox_ID.Text,TextBox_PW.Text))
            //{
            //    SQLDR.Read();

            //    if(System.Convert.ToInt32(SQLDR.GetValue(0).ToString()) != nowID)
            //    {
            //        nowID = System.Convert.ToInt32(SQLDR.GetValue(0).ToString());

            //        string sHTML = Dryer_HTML_UpdateTime + SQLDR.GetValue(1).ToString() + Dryer_HTML_Power + "NA" +Dryer_HTML_Hour + SQLDR.GetValue(4).ToString() + Dryer_HTML_INW + SQLDR.GetValue(2).ToString() + Dryer_HTML_OUTW + SQLDR.GetValue(3).ToString() + Dryer_HTML_Switch + SQLDR.GetValue(5).ToString() + Dryer_HTML_Motor + SQLDR.GetValue(6).ToString() + Dryer_HTML_FanSpeed + SQLDR.GetValue(7).ToString() + Dryer_HTML_H + SQLDR.GetValue(8).ToString() + Dryer_HTML_T + SQLDR.GetValue(9).ToString() + Dryer_HTML_END;

            //        Literal_ShowInfomation.Text = sHTML;
            //    }

            //    SQLDR.Close();
            //}
            SQL_Download("SELECT * FROM DryerTable WHERE ID = (SELECT MAX (ID) FROM DryerTable);", TextBox_ID.Text, TextBox_PW.Text);

            SQLDR.Read();

            string sHTML = Dryer_HTML_UpdateTime + SQLDR.GetValue(1).ToString() + Dryer_HTML_Power + "NA" + Dryer_HTML_Hour + SQLDR.GetValue(4).ToString() + Dryer_HTML_INW + SQLDR.GetValue(2).ToString() + Dryer_HTML_OUTW + SQLDR.GetValue(3).ToString() + Dryer_HTML_Switch + SQLDR.GetValue(5).ToString() + Dryer_HTML_Motor + SQLDR.GetValue(6).ToString() + Dryer_HTML_FanSpeed + SQLDR.GetValue(7).ToString() + Dryer_HTML_H + SQLDR.GetValue(8).ToString() + Dryer_HTML_T + SQLDR.GetValue(9).ToString() + Dryer_HTML_END;

            Literal_ShowInfomation.Text = sHTML;

            //if (System.Convert.ToInt32(SQLDR.GetValue(0).ToString()) != nowID)
            //{
            //    nowID = System.Convert.ToInt32(SQLDR.GetValue(0).ToString());

            //    string sHTML = Dryer_HTML_UpdateTime + SQLDR.GetValue(1).ToString() + Dryer_HTML_Power + "NA" + Dryer_HTML_Hour + SQLDR.GetValue(4).ToString() + Dryer_HTML_INW + SQLDR.GetValue(2).ToString() + Dryer_HTML_OUTW + SQLDR.GetValue(3).ToString() + Dryer_HTML_Switch + SQLDR.GetValue(5).ToString() + Dryer_HTML_Motor + SQLDR.GetValue(6).ToString() + Dryer_HTML_FanSpeed + SQLDR.GetValue(7).ToString() + Dryer_HTML_H + SQLDR.GetValue(8).ToString() + Dryer_HTML_T + SQLDR.GetValue(9).ToString() + Dryer_HTML_END;

            //    Literal_ShowInfomation.Text = sHTML;
            //}

            SQLDR.Close();

        }
        #endregion

        #region KEYs
        protected void Button_Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PC_Main.aspx");
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
                            Panel_Information.Enabled = true;
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
                Panel_Information.Enabled = false;
            }
        }
        #endregion

        protected void Button_Dryer_Click(object sender, EventArgs e)
        {
            //Update_Command = "Dryer";
            //nowID = 0;
            //Timer_Update.Enabled = true;
            Dryer_Refresh();
            //ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('TEST!');</script>");
            //Literal_ShowInfomation.Text = "BBBBB";
            //string sHTML = Dryer_HTML_UpdateTime + "2019/02/25 12:25:03:000" + Dryer_HTML_Power + "NA" + Dryer_HTML_Hour + "5" + Dryer_HTML_INW + "False" + Dryer_HTML_OUTW + "False" + Dryer_HTML_Switch + "False" + Dryer_HTML_Motor + "False" + Dryer_HTML_FanSpeed + "False" + Dryer_HTML_H + "50" + Dryer_HTML_T + "25" + Dryer_HTML_END;
            //Literal_ShowInfomation.Text = sHTML;
        }

        protected void Timer_Update_Tick(object sender, EventArgs e)
        {
            switch (Update_Command) {
                case "N/A":

                    break;
                case "Dryer":
                    Dryer_Refresh();
                    break;
                case "":

                    break;
            }
        }
    }
}