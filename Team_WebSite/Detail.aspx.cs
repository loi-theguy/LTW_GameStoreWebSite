using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Detail : System.Web.UI.Page
{
    
    protected override void OnPreInit(EventArgs e)
    {
        base.OnPreInit(e);
        if (Session["currentUser"] != null && Session["currentUser"].ToString() != "none") this.MasterPageFile = "MasterPage2.master";
        else this.MasterPageFile = "MasterPage.master";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Label3.Text = "";
        try
        {
            loadData();
        }
        catch (Exception ex)
        {
            Label3.Text = "This is where we display our game's detail";
            Response.Redirect("Default.aspx");
        }
    }
    public void loadData()
    {
        String tengame = Request.QueryString["tengame"].ToString();
        Label1.Text = tengame;
        String connStr = ConfigurationManager.ConnectionStrings["QLBH"].ToString();
        SqlConnection connect = new SqlConnection(connStr);
        connect.Open();
        string cmdstr = "select top 5 tengame,fname from games";
        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdstr);
        cmd.Connection = connect;
        SqlDataReader reader = cmd.ExecuteReader();
        DataList1.DataSource = reader;
        DataList1.DataBind();
        reader.Close();
        cmdstr = "select fname, gia from games where tengame=N'" + tengame + "'";
        cmd.CommandText = cmdstr;
        reader = cmd.ExecuteReader();
        reader.Read();
        Image1.ImageUrl = "~/Games/" + reader[0].ToString();
        Label2.Text = "Price: $" + reader[1].ToString();
        reader.Close();
        connect.Close();
    }
    protected string createId(int id)
    {
        string s = id.ToString();
        while (s.Length < 3)
        {
            s = '0' + s;
        }
        return s;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if(Session["currentUser"]==null|| Session["currentUser"].ToString()=="none") 
        {
            Response.Redirect("Login.aspx");
            return;
        }
        try
        {
            String tengame = Request.QueryString["tengame"].ToString();
            String username=Session["currentUser"].ToString();
            String connStr = ConfigurationManager.ConnectionStrings["QLBH"].ToString();
            SqlConnection connect = new SqlConnection(connStr);
            connect.Open();
            string cmdstr = "Select userid from users where username='" + username + "'";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdstr);
            cmd.Connection = connect;
            cmd.CommandText = cmdstr;
            String userid = cmd.ExecuteScalar().ToString();
            cmdstr = "select mahd from hoadon where thanhtoan=0 and userid='"+userid+"'";
            cmd.CommandText=cmdstr;
            object o = cmd.ExecuteScalar();
            string mahd; int i;
            if (o == null)
            {
                //tao hoa don
                cmdstr = "select top 1 mahd from hoadon order by mahd desc";
                cmd.CommandText = cmdstr;
                o = cmd.ExecuteScalar();

                if (o != null) mahd = (int.Parse(cmd.ExecuteScalar().ToString()) + 1).ToString();
                else mahd = "1";
                String ngaylap = String.Format("{0:dd/MM/yyyy}", DateTime.Now);
                cmdstr = "set dateformat dmy insert into hoadon values (" + mahd + "," + userid + ",'" + ngaylap + "',0)";
                cmd.CommandText = cmdstr;
                i = cmd.ExecuteNonQuery();
            }
            else 
            {
                mahd = o.ToString();
            }
            o = null;
            //them chi tiet vao hoa don
            cmdstr = "select magame from games where tengame=N'" + Request.QueryString["tengame"].ToString() + "'";
            cmd.CommandText = cmdstr;
            String magame = cmd.ExecuteScalar().ToString();
            cmdstr = "insert into ct_hoadon values(" + mahd + ",'"+magame + "')";
            cmd.CommandText = cmdstr;
            i = cmd.ExecuteNonQuery();
            connect.Close();
            ScriptManager.RegisterStartupScript(this, GetType(), "displayalertmessage", "thongBao();", true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "displayalertmessage", "baoLoi();", true);
        }
    }
}