using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "";
        loadData();
        xoaUser();
    }
    public void loadData()
    {
        try
        {
            String cnnstr = ConfigurationManager.ConnectionStrings["QLBH"].ToString();
            SqlConnection connect = new SqlConnection(cnnstr);
            String cmdstr = "select userid, username from users where loai=1";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdstr);
            cmd.Connection = connect;
            connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader == null)
            {
                Label1.Text = "Không có tài khoản người dùng nào trong hệ thống";
                reader.Close();
                connect.Close();
                return;
            }
            GridView1.DataSource = reader;
            GridView1.DataBind();
            reader.Close();
            connect.Close();
        }
        catch (Exception ex) { }
    }
    public void xoaUser()
    {
        if (Request.QueryString["xoa"] != null)
        {
            try
            {
                String userid = Request.QueryString["xoa"].ToString();
                String cnnstr = ConfigurationManager.ConnectionStrings["QLBH"].ToString();
                SqlConnection connect = new SqlConnection(cnnstr);
                String cmdstr = "delete users where userid=" + userid;
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdstr);
                cmd.Connection = connect;
                connect.Open();
                int i = cmd.ExecuteNonQuery();
                connect.Close();
                Response.Redirect("DeleteUsers.aspx");
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "displayalertmessage", "baoLoi();", true);
            }
        }
    }
}