using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UpdateProfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["currentUser"] == null || Session["currentUser"].ToString() == "none") Response.Redirect("Default.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (RequiredFieldValidator1.IsValid && RequiredFieldValidator2.IsValid)
        {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["QLBH"].ConnectionString;
            System.Data.SqlClient.SqlConnection connect = new System.Data.SqlClient.SqlConnection(connString);
            connect.Open();
            string cmdstr = "select matkhau from users where username ='" + Session["currentUser"].ToString() + "'";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdstr);
            cmd.Connection = connect;
            string s = cmd.ExecuteScalar().ToString();
            if (s != TextBox1.Text)
            {
                Label3.Text = "Sai mật khẩu cũ!";
            }
            else
            {
                cmdstr = "update users set matkhau ='" + TextBox2.Text + "'where username='"+Session["currentUser"].ToString()+"'";
                cmd.CommandText = cmdstr;
                int i = cmd.ExecuteNonQuery();
                Label3.Text = "Cập nhật mật khẩu thành công!";
            }
            connect.Close();
        }
    }
}