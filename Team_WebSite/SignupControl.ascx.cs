using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SignupControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //protected string createId(int id)
    //{
    //    string s = id.ToString();
    //    while (s.Length < 3)
    //    {
    //        s = '0' + s;
    //    }
    //    return s;
    //}
    protected void Button1_Click(object sender, EventArgs e)
    {
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["QLBH"].ConnectionString;
        System.Data.SqlClient.SqlConnection connect = new System.Data.SqlClient.SqlConnection(connString);
        connect.Open();
        string cmdstr = "select top 1 userid from users order by userid desc";
        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdstr);
        cmd.Connection = connect;
        int id = int.Parse(cmd.ExecuteScalar().ToString()) + 1;
        
        ////////////////////////
        //cmdstr = "select email from thanhvien";
        //cmd.CommandText = cmdstr;
        //bool checkEmail = true;
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
        ////////////////////////////
        //if (CompareValidator1.IsValid && CompareValidator2.IsValid && checkEmail)
        //{
        cmdstr = "insert into users values(" + id.ToString() + ",'" + TextBox1.Text + "','" + TextBox2.Text + "',1)";
        cmd.CommandText = cmdstr;
        int rs = cmd.ExecuteNonQuery();
        //}
        //if (!checkEmail) Label1.Visible = true;
        connect.Close();
    }
}