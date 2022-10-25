using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_HoTro_HoTro_ThemMoi : System.Web.UI.UserControl
{
    private string cn = "";
    private string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["cn"] != null) 
        cn = Request.QueryString["cn"];
        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];
        if (!IsPostBack)
        {

            HienThiThongTin(id);
        }
    }
    private void HienThiThongTin(string id)
    {
        if (cn == "sua")
        {
            btThemMoi.Text = "Chỉnh Sửa";
            DataTable dt = new DataTable();
            dt = DongPhucKhanhLinh.HoTro.thongtin_hotro_id(id);
            if (dt.Rows.Count > 0)
            {
                tbhoten.Text = dt.Rows[0]["HoTen"].ToString();
                tbsodienthoai.Text = dt.Rows[0]["SoDienThoai"].ToString();
                tbemail.Text = dt.Rows[0]["Email"].ToString();
                tbtieude.Text = dt.Rows[0]["TieuDe"].ToString();
                tbnoidung.Text = dt.Rows[0]["NoiDung"].ToString();
            }
            else
            {
                btThemMoi.Text = "Thêm Mới";
                cbThemNhieuDanhMuc.Visible = true;


            }
        }
    }

    protected void btThemMoi_Click(object sender, EventArgs e)
    {
        if (cn == "themmoi")
        {


            DongPhucKhanhLinh.HoTro.hotro_insert(tbhoten.Text,tbsodienthoai.Text, tbemail.Text, tbtieude.Text, tbnoidung.Text);


            if (cbThemNhieuDanhMuc.Checked)
            {
                //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
                ResetControl();
            }

            else
            {
                //đẩy trang về trang danh sách các damnh mục đã tạo

                Response.Redirect("Admin.aspx?dm=hotro&cn=hienthi");
            }
        }
        else
        {


            DongPhucKhanhLinh.HoTro.hotro_Update(id, tbhoten.Text, tbsodienthoai.Text, tbemail.Text, tbtieude.Text, tbnoidung.Text);

            //đẩy trang về trang danh sách các damnh mục đã tạo
            Response.Redirect("Admin.aspx?dm=hotro&cn=hienthi");
        }



    }

    private void ResetControl()
    {

        tbhoten.Text = ""; tbsodienthoai.Text = ""; tbemail.Text = ""; tbtieude.Text = ""; tbnoidung.Text = "";
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {

    }
}