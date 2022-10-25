using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Button1_Click(object sender, EventArgs e)
    {

        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.TaiKhoan.Thongtin_DangKy_by_id_matkhau(tbdangnhap.Text, DongPhucKhanhLinh.MaHoa.MaHoaMD5(tbmatkhau.Text));
        if (dt.Rows.Count > 0)
        {
            Session["dangnhap"] = "1";

            Session["tentk"] = dt.Rows[0]["TenTK"];

            Response.Redirect("/Admin.aspx");


        }
        else
        {
            ltrthongbao.Text = "<div class='thongbao'>bạn đã nhập sai tài khoản hoặc mật khẩu</div>";
        }
    }
}