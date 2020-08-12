using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditGames : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label5.Text = "";
        if (Request.QueryString["xem"] != null && Request.QueryString["xem"].ToString() == "yes") loadList();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int t;
        if (!int.TryParse(TextBox1.Text, out t))
        {
            Label1.Text = "Lỗi: Mã game phải là 1 con số nguyên";
            return;
        }
        float f;
        if (!float.TryParse(TextBox3.Text, out f)) {
            Label1.Text = "Lỗi: Giá bán phải là 1 con số thực";
            return;
        }
        if (TextBox1.Text == "")
        {
            Label1.Text = "Lỗi: Ô mã game bị trống";
            return;
        }
        if (TextBox2.Text == "")
        {
            Label1.Text = "Lỗi: Ô tên game bị trống";
            return;
        }
        if (TextBox3.Text == "")
        {
            Label1.Text = "Lỗi: Ô giá bán của game bị trống";
            return;
        }
        if (FileUpload1.FileName == "")
        {
            Label1.Text = "Lỗi: Chưa đăng ảnh đại diện game";
            return;
        }
        if (true)
        {
            try
            {
                String cmdstr = "insert into games values(" + TextBox1.Text + ",N'" + TextBox2.Text + "'," + TextBox3.Text + ",'" + FileUpload1.FileName + "')";
                FileUpload1.SaveAs(Server.MapPath("~") + "/Games/" + FileUpload1.FileName);
                String connStr = ConfigurationManager.ConnectionStrings["QLBH"].ToString();
                SqlConnection connect = new SqlConnection(connStr);
                connect.Open();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdstr);
                cmd.Connection = connect;
                int i = cmd.ExecuteNonQuery();
                connect.Close();
                Label1.Text = "Thêm thành công!";
            }
            catch (Exception ex)
            {
                Label1.Text = "Lỗi: Mã game bị trùng";
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int t;
        if (!int.TryParse(TextBox7.Text, out t))
        {
            Label3.Text = "Lỗi: Mã game phải là 1 con số nguyên";
            return;
        }
        if (TextBox7.Text == "")
        {
            Label3.Text = "Lỗi: Ô mã game bị trống";
            return;
        }
        if (true)
        {
            try
            {
                String cmdstr = "delete games where magame=" + TextBox7.Text;
                String connStr = ConfigurationManager.ConnectionStrings["QLBH"].ToString();
                SqlConnection connect = new SqlConnection(connStr);
                connect.Open();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdstr);
                cmd.Connection = connect;
                int i = cmd.ExecuteNonQuery();
                connect.Close();
                Label3.Text = "Xóa thành công";
            }
            catch (Exception ex)
            {
            }
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        int t;
        if (!int.TryParse(TextBox4.Text, out t))
        {
            Label2.Text = "Lỗi: Mã game phải là 1 con số nguyên";
            return;
        }
        if (TextBox4.Text == "")
        {
            Label2.Text = "Lỗi: Ô mã game bị trống";
            return;
        }
        if (true)
        {
            try
            {
                float f;
                String cmdstr = "";
                String connStr = ConfigurationManager.ConnectionStrings["QLBH"].ToString();
                SqlConnection connect = new SqlConnection(connStr);
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdstr);
                connect.Open();
                int i;
                cmd.Connection = connect;
                if (TextBox5.Text != "")
                {
                    cmdstr = "update games set tengame=N'"+TextBox5.Text+"' where magame=" + TextBox4.Text;
                    cmd.CommandText = cmdstr;
                    i = cmd.ExecuteNonQuery();
                }
                if (TextBox6.Text != "")
                {
                    if (!float.TryParse(TextBox6.Text, out f))
                    {
                        Label2.Text = "Lỗi: Giá bán phải là 1 con số thực";
                        return;
                    }
                    cmdstr = "update games set gia=" + TextBox6.Text + " where magame=" + TextBox4.Text;
                    cmd.CommandText = cmdstr;
                    i = cmd.ExecuteNonQuery();
                }
                if (FileUpload2.FileName != "")
                {
                    cmdstr = "update games set fname='" + FileUpload1.FileName + "' where magame=" + TextBox4.Text ;
                    cmd.CommandText = cmdstr;
                    i = cmd.ExecuteNonQuery();
                    FileUpload2.SaveAs(Server.MapPath("~") + "/Games/" + FileUpload2.FileName);
                }
                connect.Close();
                Label2.Text = "Cập nhật thành công!";
            }
            catch (Exception ex)
            {
            }
        }
    }
    public void loadList()
    {
        String cnnstr = ConfigurationManager.ConnectionStrings["QLBH"].ToString();
        SqlConnection connect = new SqlConnection(cnnstr);
        String cmdstr = "select * from games";
        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdstr);
        cmd.Connection = connect;
        connect.Open();
        SqlDataReader reader = cmd.ExecuteReader();
        if (reader == null)
        {
            Label5.Text = "Danh sách trống, vui lòng thêm game vào danh sách";
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