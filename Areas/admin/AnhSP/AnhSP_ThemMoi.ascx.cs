using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_AnhSP_AnhSP_ThemMoi : System.Web.UI.UserControl
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
            LayDanhMuc();
        }
    }
    private void HienThiThongTin(string id)
    {
        if (cn == "sua")
        {
            btThemMoi.Text = "Chỉnh Sửa";
            DataTable dt = new DataTable();
            dt = DongPhucKhanhLinh.AnhSP.thongtin_anhsp_id(id);
            if (dt.Rows.Count > 0)
            {
                ddldanhmuc.SelectedValue = dt.Rows[0]["MaAnhSP"].ToString();
                ltrAnhDaiDien.Text = "<img class='anhDaiDien'src='/pic/SanPham/" + dt.Rows[0]["AnhSP"] + @"'/>";
                hdTenAnhDaiDienCu.Value = dt.Rows[0]["AnhSP"].ToString();
               
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
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/SanPham/") + flAnhDaiDien.FileName);
                }
            }

            DongPhucKhanhLinh.AnhSP.anhsp_insert(ddldanhmuc.SelectedValue,flAnhDaiDien.FileName);


            if (cbThemNhieuDanhMuc.Checked)
            {
                //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
                ResetControl();
            }

            else
            {
                //đẩy trang về trang danh sách các damnh mục đã tạo

                Response.Redirect("Admin.aspx?dm=anhsanpham&cn=hienthi");
            }
        }
        else
        {
            string tenAnhDaiDien = "";

            if (flAnhDaiDien.FileContent.Length > 0)
            {
                if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
                {
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/SanPham/") + flAnhDaiDien.FileName);
                    tenAnhDaiDien = flAnhDaiDien.FileName;

                    // viết đoạn code xóa ảnh đại diện cũ tại đây - tạm thời chưa viết
                }
            }

            if (tenAnhDaiDien == "")
            {
                tenAnhDaiDien = hdTenAnhDaiDienCu.Value;
            }


            DongPhucKhanhLinh.AnhSP.anhsp_Update(id,  ddldanhmuc.SelectedValue, flAnhDaiDien.FileName);

            //đẩy trang về trang danh sách các damnh mục đã tạo
            Response.Redirect("Admin.aspx?dm=anhsanpham&cn=hienthi");
        }



    }

    private void ResetControl()
    {
         
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {

    }

    private void LayDanhMuc()
    {
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.SanPham.Thongtin_sanpham();
        ddldanhmuc.Items.Clear();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddldanhmuc.Items.Add(new ListItem( dt.Rows[i]["TenSP"].ToString(), dt.Rows[i]["MaSP"].ToString()));
            //LayDanhMucCon(dt.Rows[i]["MaDM"].ToString(), "___");
        }
    }
}