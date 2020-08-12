using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Search : System.Web.UI.Page
{
    protected override void OnPreInit(EventArgs e)
    {
        base.OnPreInit(e);
        if (Session["currentUser"] != null && Session["currentUser"].ToString() != "none") this.MasterPageFile = "MasterPage2.master";
        else this.MasterPageFile = "MasterPage.master";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Text = "";
        loadSearchResult();
    }
    public void loadSearchResult()
    {
        if (Request.QueryString["keyword"] != null)
        {
            String keyword = Request.QueryString["keyword"].ToString();
            String cnnstr = ConfigurationManager.ConnectionStrings["QLBH"].ToString();
            SqlConnection connect = new SqlConnection(cnnstr);
            String cmdstr = "select * from games where tengame like '" + keyword+"%'";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdstr);
            cmd.Connection = connect;
            connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader == null) {
                Label2.Text = "Không có tên game phù hợp với từ khóa "+keyword;
                reader.Close();
                connect.Close();
                return;
            }
            DataList1.DataSource = reader;
            DataList1.DataBind();
            reader.Close();
            connect.Close();
        }
    }
}