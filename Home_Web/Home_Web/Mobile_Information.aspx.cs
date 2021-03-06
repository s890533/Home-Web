﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Home_Web
{
    public partial class Mobile_Information : System.Web.UI.Page
    {
        string strConn1 = "server=tcp:HOMEIOT-SERVER,65535;database=IOT;User ID=";
        string strConn2 = ";Password=";
        string strConn3 = ";";

        int nowID = 0;
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

        private bool SQL_Download(String Command, String ID, String PW)
        {
            bool ans = false;

            try
            {
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
        string Dryer_HTML_UpdateTime = "<body lang=ZH-TW link=\"#0563C1\" vlink=\"#954F72\"><div class=WordSection1><table class=MsoNormalTable border=1 cellspacing=0 cellpadding=0 style='border-collapse:collapse;border:none'><tr style='height:42.55pt'><td width=236 style='width:176.8pt;border:solid white 1.0pt;background:#5B9BD5;padding:0cm 5.4pt 0cm 5.4pt;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'>Update Time<o:p></o:p></span></p></td><td width=369 style='width:276.4pt;border:solid white 1.0pt;border-left:none;background:#002060;padding:0cm 0cm 0cm 0cm;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'><span style='color:white'>";
        string Dryer_HTML_Power = "</span><span style='color:white'><o:p></o:p></span></span></p></td></tr><tr style='height:42.55pt'><td width=236 style='width:176.8pt;border:solid white 1.0pt;border-top:none;background:#5B9BD5;padding:0cm 5.4pt 0cm 5.4pt;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'>Power<o:p></o:p></span></p></td><td width=369 style='width:276.4pt;border-top:none;border-left:none;border-bottom:solid white 1.0pt;border-right:solid white 1.0pt;background:#002060;padding:0cm 0cm 0cm 0cm;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'><span style='color:white'>";
        string Dryer_HTML_Power_Error = "</span><span style='color:white'><o:p></o:p></span></span></p></td></tr><tr style='height:42.55pt'><td width=236 style='width:176.8pt;border:solid white 1.0pt;border-top:none;background:#5B9BD5;padding:0cm 5.4pt 0cm 5.4pt;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'>Power<o:p></o:p></span></p></td><td width=369 style='width:276.4pt;border-top:none;border-left:none;border-bottom:solid white 1.0pt;border-right:solid white 1.0pt;background:#C00000;padding:0cm 0cm 0cm 0cm;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'><span style='color:white'>";

        string Dryer_HTML_Hour = "</span><span style='color:white'><o:p></o:p></span></span></p></td></tr><tr style='height:42.55pt'><td width=236 style='width:176.8pt;border:solid white 1.0pt;border-top:none;background:#5B9BD5;padding:0cm 5.4pt 0cm 5.4pt;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'>Hour<o:p></o:p></span></p></td><td width=369 style='width:276.4pt;border-top:none;border-left:none;border-bottom:solid white 1.0pt;border-right:solid white 1.0pt;background:#002060;padding:0cm 0cm 0cm 0cm;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'><span style='color:white'>";
        string Dryer_HTML_INW = "</span><span style='color:white'><o:p></o:p></span></span></p></td></tr><tr style='height:42.55pt'><td width=236 style='width:176.8pt;border:solid white 1.0pt;border-top:none;background:#5B9BD5;padding:0cm 5.4pt 0cm 5.4pt;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'>Inside Water<o:p></o:p></span></p></td><td width=369 style='width:276.4pt;border-top:none;border-left:none;border-bottom:solid white 1.0pt;border-right:solid white 1.0pt;background:#002060;padding:0cm 0cm 0cm 0cm;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'><span style='color:white'>";
        string Dryer_HTML_INW_Error = "</span><span style='color:white'><o:p></o:p></span></span></p></td></tr><tr style='height:42.55pt'><td width=236 style='width:176.8pt;border:solid white 1.0pt;border-top:none;background:#5B9BD5;padding:0cm 5.4pt 0cm 5.4pt;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'>Inside Water<o:p></o:p></span></p></td><td width=369 style='width:276.4pt;border-top:none;border-left:none;border-bottom:solid white 1.0pt;border-right:solid white 1.0pt;background:#C00000;padding:0cm 0cm 0cm 0cm;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'><span style='color:white'>";

        string Dryer_HTML_OUTW = "</span><span style='color:white'><o:p></o:p></span></span></p></td></tr><tr style='height:42.55pt'><td width=236 style='width:176.8pt;border:solid white 1.0pt;border-top:none;background:#5B9BD5;padding:0cm 5.4pt 0cm 5.4pt;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'>Outside Water<o:p></o:p></span></p></td><td width=369 style='width:276.4pt;border-top:none;border-left:none;border-bottom:solid white 1.0pt;border-right:solid white 1.0pt;background:#002060;padding:0cm 0cm 0cm 0cm;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'><span style='color:white'>";
        string Dryer_HTML_OUTW_Error = "</span><span style='color:white'><o:p></o:p></span></span></p></td></tr><tr style='height:42.55pt'><td width=236 style='width:176.8pt;border:solid white 1.0pt;border-top:none;background:#5B9BD5;padding:0cm 5.4pt 0cm 5.4pt;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'>Outside Water<o:p></o:p></span></p></td><td width=369 style='width:276.4pt;border-top:none;border-left:none;border-bottom:solid white 1.0pt;border-right:solid white 1.0pt;background:#C00000;padding:0cm 0cm 0cm 0cm;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'><span style='color:white'>";

        string Dryer_HTML_Switch = "</span><span style='color:white'><o:p></o:p></span></span></p></td></tr><tr style='height:42.55pt'><td width=236 style='width:176.8pt;border:solid white 1.0pt;border-top:none;background:#5B9BD5;padding:0cm 5.4pt 0cm 5.4pt;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'>Switch<o:p></o:p></span></p></td><td width=369 style='width:276.4pt;border-top:none;border-left:none;border-bottom:solid white 1.0pt;border-right:solid white 1.0pt;background:#002060;padding:0cm 0cm 0cm 0cm;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'><span style='color:white'>";
        string Dryer_HTML_Switch_Error = "</span><span style='color:white'><o:p></o:p></span></span></p></td></tr><tr style='height:42.55pt'><td width=236 style='width:176.8pt;border:solid white 1.0pt;border-top:none;background:#5B9BD5;padding:0cm 5.4pt 0cm 5.4pt;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'>Switch<o:p></o:p></span></p></td><td width=369 style='width:276.4pt;border-top:none;border-left:none;border-bottom:solid white 1.0pt;border-right:solid white 1.0pt;background:#C00000;padding:0cm 0cm 0cm 0cm;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'><span style='color:white'>";

        string Dryer_HTML_Motor = "</span><span style='color:white'><o:p></o:p></span></span></p></td></tr><tr style='height:42.55pt'><td width=236 style='width:176.8pt;border:solid white 1.0pt;border-top:none;background:#5B9BD5;padding:0cm 5.4pt 0cm 5.4pt;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'>Motor<o:p></o:p></span></p></td><td width=369 style='width:276.4pt;border-top:none;border-left:none;border-bottom:solid white 1.0pt;border-right:solid white 1.0pt;background:#002060;padding:0cm 0cm 0cm 0cm;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'><span style='color:white'>";
        string Dryer_HTML_Motor_Error = "</span><span style='color:white'><o:p></o:p></span></span></p></td></tr><tr style='height:42.55pt'><td width=236 style='width:176.8pt;border:solid white 1.0pt;border-top:none;background:#5B9BD5;padding:0cm 5.4pt 0cm 5.4pt;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'>Motor<o:p></o:p></span></p></td><td width=369 style='width:276.4pt;border-top:none;border-left:none;border-bottom:solid white 1.0pt;border-right:solid white 1.0pt;background:#C00000;padding:0cm 0cm 0cm 0cm;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'><span style='color:white'>";

        string Dryer_HTML_FanSpeed = "</span><span style='color:white'><o:p></o:p></span></span></p></td></tr><tr style='height:42.55pt'><td width=236 style='width:176.8pt;border:solid white 1.0pt;border-top:none;background:#5B9BD5;padding:0cm 5.4pt 0cm 5.4pt;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'>Fan Speed<o:p></o:p></span></p></td><td width=369 style='width:276.4pt;border-top:none;border-left:none;border-bottom:solid white 1.0pt;border-right:solid white 1.0pt;background:#002060;padding:0cm 0cm 0cm 0cm;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'><span style='color:white'>";
        string Dryer_HTML_H = "</span><span style='color:white'><o:p></o:p></span></span></p></td></tr><tr style='height:42.55pt'><td width=236 style='width:176.8pt;border:solid white 1.0pt;border-top:none;background:#5B9BD5;padding:0cm 5.4pt 0cm 5.4pt;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'>Humidity<o:p></o:p></span></p></td><td width=369 style='width:276.4pt;border-top:none;border-left:none;border-bottom:solid white 1.0pt;border-right:solid white 1.0pt;background:#002060;padding:0cm 0cm 0cm 0cm;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'><span style='color:white'>";
        string Dryer_HTML_H_Error = "</span><span style='color:white'><o:p></o:p></span></span></p></td></tr><tr style='height:42.55pt'><td width=236 style='width:176.8pt;border:solid white 1.0pt;border-top:none;background:#5B9BD5;padding:0cm 5.4pt 0cm 5.4pt;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'>Humidity<o:p></o:p></span></p></td><td width=369 style='width:276.4pt;border-top:none;border-left:none;border-bottom:solid white 1.0pt;border-right:solid white 1.0pt;background:#C00000;padding:0cm 0cm 0cm 0cm;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'><span style='color:white'>";

        string Dryer_HTML_T = "</span><span style='color:white'><o:p></o:p></span></span></p></td></tr><tr style='height:42.55pt'><td width=236 style='width:176.8pt;border:solid white 1.0pt;border-top:none;background:#5B9BD5;padding:0cm 5.4pt 0cm 5.4pt;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'>Temperature<o:p></o:p></span></p></td><td width=369 style='width:276.4pt;border-top:none;border-left:none;border-bottom:solid white 1.0pt;border-right:solid white 1.0pt;background:#002060;padding:0cm 0cm 0cm 0cm;height:42.55pt'><p class=MsoNormal align=center style='text-align:center'><span lang=EN-US style='font-size:22.0pt;color:white'><span style='color:white'>";
        string Dryer_HTML_END = "</span><span style='color:white'><o:p></o:p></span></span></p></td></tr></table><p class=MsoNormal><span lang=EN-US><o:p>&nbsp;</o:p></span></p></div></body>";
        private void Dryer_Refresh()
        {
            string sHTML = "";

            try
            {
                SqlConnection sql = new SqlConnection(strConn1 + TextBox_ID.Text + strConn2 + TextBox_PW.Text + strConn3);

                sql.Open();

                SqlCommand sqlcmd = new SqlCommand();

                sqlcmd.Connection = sql;

                sqlcmd.CommandText = "SELECT * FROM DryerTable WHERE ID = (SELECT MAX(ID) FROM DryerTable);";

                SqlDataReader sqlreader = sqlcmd.ExecuteReader();

                if (sqlreader.HasRows)
                {
                    if (sqlreader.Read())
                    {
                        if (System.Convert.ToInt32(sqlreader.GetValue(0).ToString()) != nowID)
                        {
                            nowID = System.Convert.ToInt32(sqlreader.GetValue(0).ToString());

                            sHTML = Dryer_HTML_UpdateTime + sqlreader.GetValue(1).ToString();

                            if (sqlreader.GetValue(10).ToString() == "True")
                            {
                                sHTML = sHTML + Dryer_HTML_Power + sqlreader.GetValue(10).ToString();
                            }
                            else
                            {
                                sHTML = sHTML + Dryer_HTML_Power_Error + sqlreader.GetValue(10).ToString();
                            }

                            sHTML = sHTML + Dryer_HTML_Hour + sqlreader.GetValue(4).ToString();

                            if (sqlreader.GetValue(2).ToString() == "False")
                            {
                                sHTML = sHTML + Dryer_HTML_INW + sqlreader.GetValue(2).ToString();
                            }
                            else
                            {
                                sHTML = sHTML + Dryer_HTML_INW_Error + sqlreader.GetValue(2).ToString();
                            }

                            if (sqlreader.GetValue(3).ToString() == "False")
                            {
                                sHTML = sHTML + Dryer_HTML_OUTW + sqlreader.GetValue(3).ToString();
                            }
                            else
                            {
                                sHTML = sHTML + Dryer_HTML_OUTW_Error + sqlreader.GetValue(3).ToString();
                            }

                            if (sqlreader.GetValue(5).ToString() == "True")
                            {
                                sHTML = sHTML + Dryer_HTML_Switch + sqlreader.GetValue(5).ToString();
                            }
                            else
                            {
                                sHTML = sHTML + Dryer_HTML_Switch_Error + sqlreader.GetValue(5).ToString();
                            }

                            if (sqlreader.GetValue(6).ToString() == "False")
                            {
                                sHTML = sHTML + Dryer_HTML_Motor + sqlreader.GetValue(6).ToString();
                            }
                            else
                            {
                                sHTML = sHTML + Dryer_HTML_Motor_Error + sqlreader.GetValue(6).ToString();
                            }

                            sHTML = sHTML + Dryer_HTML_FanSpeed + sqlreader.GetValue(7).ToString();

                            if (System.Convert.ToInt32(sqlreader.GetValue(8).ToString()) < 65 && sqlreader.GetValue(10).ToString() == "False")
                            {
                                sHTML = sHTML + Dryer_HTML_H + sqlreader.GetValue(8).ToString();
                            }
                            else
                            {
                                sHTML = sHTML + Dryer_HTML_H_Error + sqlreader.GetValue(8).ToString();
                            }

                            sHTML = sHTML + Dryer_HTML_T + sqlreader.GetValue(9).ToString() + Dryer_HTML_END;

                            Literal_ShowInfomation.Text = sHTML;
                        }

                    }
                }
                else
                {

                }

                sqlcmd.Dispose();

                sql.Dispose();

            }
            catch
            {

            }

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

        protected void Button_Dryer_Click(object sender, EventArgs e)
        {
            if(Label_Command.Text == "Dryer")
            {
                Dryer_Refresh();
            }
            else
            {
                Dryer_Refresh();
                Label_Command.Text = "Dryer";
                nowID = 0;
                Timer_Update.Enabled = true;
            }
            
            
        }

        protected void Timer_Update_Tick(object sender, EventArgs e)
        {
            switch (Label_Command.Text)
            {
                case "N/A":

                    break;
                case "Dryer":
                    //Dryer_Refresh();
                    break;
                case "":

                    break;
            }
        }
        #endregion
    }
}