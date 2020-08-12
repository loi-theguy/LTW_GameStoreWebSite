using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    List<Label> list = new List<Label>();
    List<ImageButton> list2 = new List<ImageButton>();
    protected void initList()
    {
        list.Add(Label1);
        list.Add(Label2);
        list.Add(Label3);
        list.Add(Label4);
        list.Add(Label5);
        list.Add(Label6);
        list.Add(Label7);
        list.Add(Label8);
        list.Add(Label9);
        list.Add(Label10);
        list.Add(Label11);
        list.Add(Label12);
        list.Add(Label13);
        list.Add(Label14);
        list.Add(Label15);
        list.Add(Label16);
        list.Add(Label17);
        list.Add(Label18);
        list.Add(Label19);
        list.Add(Label20);
        list.Add(Label21);
        list.Add(Label22);
        list.Add(Label23);
        list.Add(Label24);
        list2.Add(ImageButton1);
        list2.Add(ImageButton2);
        list2.Add(ImageButton3);
        list2.Add(ImageButton4);
        list2.Add(ImageButton5);
        list2.Add(ImageButton6);
        list2.Add(ImageButton7);
        list2.Add(ImageButton8);
        list2.Add(ImageButton9);
        list2.Add(ImageButton10);
        list2.Add(ImageButton11);
        list2.Add(ImageButton12);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["signout"] != null)
        {
            if (Request.QueryString["signout"].ToString() == "yes") Session["currentUser"] = "none";
        }
        if (Session["currentUser"] == null) Session.Add("currentUser", "none");
        else {
            string currentUser = Session["currentUser"].ToString();
            if (currentUser == "admin") Response.Redirect("Default2.aspx");
            else if(currentUser!="none") Response.Redirect("Default3.aspx");
        }
        initList();
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["QLBH"].ConnectionString;
        System.Data.SqlClient.SqlConnection connect = new System.Data.SqlClient.SqlConnection(connString);
        connect.Open();
        string cmdstr;
        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        cmd.Connection = connect;
        for (int i = 0; i < list2.Count; i++)
        { 
            string fname=list2[i].ImageUrl.Substring(8,list2[i].ImageUrl.Length-8);
            cmdstr = "select tengame from games where fname='" + fname + "'";
            cmd.CommandText = cmdstr;
            string kq=cmd.ExecuteScalar().ToString();
            list[i + 12].Text = kq;
            cmdstr = "select gia from games where fname='" + fname + "'";
            cmd.CommandText = cmdstr;
            kq = cmd.ExecuteScalar().ToString();
            list[i].Text = kq;
        }
        //System.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader();
        //while (reader.Read())
        //{
        //    System.Data.IDataRecord read = reader;
        //    if (TextBox2.Text == read[0].ToString())
        //    {
        //        checkEmail = false;
        //        break;
        //    }
        //}
        //reader.Close();
        connect.Close();
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Detail.aspx?tengame=" + Label13.Text);
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Detail.aspx?tengame=" + Label14.Text);
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Detail.aspx?tengame=" + Label15.Text);
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Detail.aspx?tengame=" + Label16.Text);
    }
    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Detail.aspx?tengame=" + Label17.Text);
    }
    protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Detail.aspx?tengame=" + Label18.Text);
    }
    protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Detail.aspx?tengame=" + Label19.Text);
    }
    protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Detail.aspx?tengame=" + Label20.Text);
    }
    protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Detail.aspx?tengame=" + Label21.Text);
    }
    protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Detail.aspx?tengame=" + Label22.Text);
    }
    protected void ImageButton11_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Detail.aspx?tengame=" + Label23.Text);
    }
    protected void ImageButton12_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Detail.aspx?tengame=" + Label24.Text);
    }
}