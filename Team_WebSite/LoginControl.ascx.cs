using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoginControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["QLBH"].ConnectionString;
            System.Data.SqlClient.SqlConnection connect = new System.Data.SqlClient.SqlConnection(connString);
            connect.Open();
            string cmdstr = "select matkhau from users where username ='" + TextBox1.Text + "'";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdstr);
            cmd.Connection = connect;
            string s = cmd.ExecuteScalar().ToString();
            if (s != TextBox2.Text)
            {
                Label1.Text = "Wrong Password!";
            }
            else
            {
                Label1.Text = "Hello, " + TextBox1.Text;
                cmdstr = "select loai from users where username='" + TextBox1.Text + "'";
                cmd.CommandText = cmdstr;
                s = cmd.ExecuteScalar().ToString();
                if (s == "0")
                {
                    Session["currentUser"] = "admin";
                    Response.Redirect("Default2.aspx");
                }
                else
                {
                    Session["currentUser"] = TextBox1.Text;
                    Response.Redirect("Default3.aspx");
                }
            }
            connect.Close();
        }
        catch(Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "displayalertmessage", "baoLoi();", true);
        }
    }
}