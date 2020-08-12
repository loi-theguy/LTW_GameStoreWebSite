using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cart : System.Web.UI.Page
{
    String mahd="";
    protected override void OnPreInit(EventArgs e)
    {
        base.OnPreInit(e);
        if (Session["currentUser"] != null && Session["currentUser"].ToString() != "none") this.MasterPageFile = "MasterPage2.master";
        else this.MasterPageFile = "MasterPage.master";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["currentUser"] == null || Session["currentUser"].ToString() == "none")
        {
            Response.Redirect("Login.aspx");
            return;
        }
        loadGioHang();
        xoaChiTiet();

    }
    public void loadGioHang()
    {
        String cnnstr = ConfigurationManager.ConnectionStrings["QLBH"].ToString();
        SqlConnection connect = new SqlConnection(cnnstr);
        String cmdstr = "select h.mahd, g.magame,tengame,gia from games g, hoadon h, ct_hoadon c where g.magame=c.magame and thanhtoan=0"
            +" and h.mahd=c.mahd and h.userid in(select u.userid from users u, hoadon h where h.userid=u.userid and username=N'"+Session["currentUser"].ToString()+"')";
        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdstr);
        cmd.Connection = connect;
        connect.Open();
        
        SqlDataReader reader = cmd.ExecuteReader();
        if (reader == null)
        {
            Label1.Text = "Bạn chưa thêm Game nào vào giỏ hàng";
        }
        else {
            if (reader.Read())
            {
                mahd = reader[0].ToString();
                Label2.Text = mahd;
                reader.Close();
                reader = cmd.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();
                reader.Close();
                cmdstr = "select sum(gia) as tongtien from games g, ct_hoadon c where mahd=" + mahd + " and g.magame=c.magame";
                cmd.CommandText = cmdstr;
                Label1.Text = "Tổng tiền: $" + cmd.ExecuteScalar().ToString();
            }
            else {
                Label1.Text = "Bạn chưa thêm Game nào vào giỏ hàng";
            }
        }
        reader.Close();
        connect.Close();
    }
    //public void loadList()
    //{ 
    
    //}
    protected void Button1_Click(object sender, EventArgs e)
    {
        String cnnstr = ConfigurationManager.ConnectionStrings["QLBH"].ToString();
        SqlConnection connect = new SqlConnection(cnnstr);
        String cmdstr = "update hoadon set thanhtoan=1 where mahd="+mahd;
        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdstr);
        cmd.Connection = connect;
        connect.Open();
        int i = cmd.ExecuteNonQuery();
        connect.Close();
        Response.Redirect("Cart.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        String cnnstr = ConfigurationManager.ConnectionStrings["QLBH"].ToString();
        SqlConnection connect = new SqlConnection(cnnstr);
        String cmdstr = "delete ct_hoadon where mahd=" + mahd;
        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdstr);
        cmd.Connection = connect;
        connect.Open();
        int i = cmd.ExecuteNonQuery();
        connect.Close();
        Response.Redirect("Cart.aspx");
    }
    public void xoaChiTiet()
    {
        if (Request.QueryString["xoa"] != null)
        {
            String magame = Request.QueryString["xoa"].ToString();
            String cnnstr = ConfigurationManager.ConnectionStrings["QLBH"].ToString();
            SqlConnection connect = new SqlConnection(cnnstr);
            String cmdstr = "delete ct_hoadon where mahd=" + mahd + " and magame="+magame;
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdstr);
            cmd.Connection = connect;
            connect.Open();
            int i = cmd.ExecuteNonQuery();
            connect.Close();
            Response.Redirect("Cart.aspx");
        }
    }
}