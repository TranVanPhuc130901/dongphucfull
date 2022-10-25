using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_DanhSachCuaHang_DanhSachCuaHang_ThemMoi : System.Web.UI.UserControl
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
            dt = DongPhucKhanhLinh.DanhSachCuaHang.thongtin_danhsachcuahang_id(id);
            if (dt.Rows.Count > 0)
            {

                tbdiachi.Text = dt.Rows[0]["DiaChi"].ToString();
                tbsdt.Text = dt.Rows[0]["SoDienThoai"].ToString();
                tbemail.Text = dt.Rows[0]["Email"].ToString();
                tblink.Text = dt.Rows[0]["Link"].ToString();
                ltrAnhDaiDien.Text = "<img class='anhDaiDien'src='/pic/AnhCuaHang/" + dt.Rows[0]["AnhCuaHang"] + @"'/>";
                hdTenAnhDaiDienCu.Value = dt.Rows[0]["AnhCuaHang"].ToString();
                tbchucnang.Text = dt.Rows[0]["ChucNang"].ToString();
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

            if (flAnhDaiDien.FileContent.Length > 0)
            {
                if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
                {
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/AnhCuaHang/") + flAnhDaiDien.FileName);
                }
            }

            DongPhucKhanhLinh.DanhSachCuaHang.danhsachcuahang_insert( tbdiachi.Text, tbsdt.Text, tbemail.Text, tblink.Text,flAnhDaiDien.FileName, tbchucnang.Text);


            if (cbThemNhieuDanhMuc.Checked)
            {
                //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
                ResetControl();
            }

            else
            {
                //đẩy trang về trang danh sách các damnh mục đã tạo

                Response.Redirect("Admin.aspx?dm=thongtincuahang&cn=hienthi");
            }
        }
        else
        {
            string tenAnhDaiDien = "";
            if (flAnhDaiDien.FileContent.Length > 0)
            {
                if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
                {
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/AnhCuaHang/") + flAnhDaiDien.FileName);
                    tenAnhDaiDien = flAnhDaiDien.FileName;

                    // viết đoạn code xóa ảnh đại diện cũ tại đây - tạm thời chưa viết
                }
            }

            if (tenAnhDaiDien == "")
            {
                tenAnhDaiDien = hdTenAnhDaiDienCu.Value;
            }


            DongPhucKhanhLinh.DanhSachCuaHang.danhsachcuahang_Update(id, tbdiachi.Text, tbsdt.Text, tbemail.Text, tblink.Text, flAnhDaiDien.FileName, tbchucnang.Text);

            //đẩy trang về trang danh sách các damnh mục đã tạo
            Response.Redirect("Admin.aspx?dm=thongtincuahang&cn=hienthi");
        }



    }

    private void ResetControl()
    {

        tbdiachi.Text = "";
        tbsdt.Text = "";
        tbemail.Text = "";
        tblink.Text = "";
        tbchucnang.Text = "";
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {

    }
}