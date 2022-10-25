using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_SanPham_SanPham_ThemMoi : System.Web.UI.UserControl
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
            dt = DongPhucKhanhLinh.SanPham.thongtin_sanpham_id(id);
            if (dt.Rows.Count > 0)
            {

                tbtensp.Text = dt.Rows[0]["TenSP"].ToString();
                ddldanhmuc.SelectedValue = dt.Rows[0]["MaDMSP"].ToString();
                tbmota.Text = dt.Rows[0]["MoTa"].ToString();
                tbmausac.Text = dt.Rows[0]["MauSac"].ToString();
                tbsize.Text = dt.Rows[0]["Size"].ToString();
                tbkm.Text = dt.Rows[0]["KhuyenMai"].ToString();
                ltrAnhDaiDien.Text = "<img class='anhDaiDien'src='/pic/SanPham/" + dt.Rows[0]["AnhSP"] + @"'/>";
                hdTenAnhDaiDienCu.Value = dt.Rows[0]["AnhSP"].ToString();
                tbgia.Text = dt.Rows[0]["Gia"].ToString();
                tbgiakm.Text = dt.Rows[0]["GiaKM"].ToString();
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
           
            DongPhucKhanhLinh.SanPham.sanpham_insert(tbtensp.Text,ddldanhmuc.SelectedValue,tbmota.Text,tbmausac.Text,tbsize.Text,tbkm.Text, flAnhDaiDien.FileName, tbgia.Text, tbgiakm.Text);


            if (cbThemNhieuDanhMuc.Checked)
            {
                //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
                ResetControl();
            }

            else
            {
                //đẩy trang về trang danh sách các damnh mục đã tạo

                Response.Redirect("Admin.aspx?dm=sanpham&cn=hienthi");
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

            
            DongPhucKhanhLinh.SanPham.sanpham_Update( id,tbtensp.Text, ddldanhmuc.SelectedValue, tbmota.Text, tbmausac.Text, tbsize.Text, tbkm.Text, flAnhDaiDien.FileName, tbgia.Text, tbgiakm.Text);

            //đẩy trang về trang danh sách các damnh mục đã tạo
            Response.Redirect("Admin.aspx?dm=sanpham&cn=hienthi");
        }



    }

    private void ResetControl()
    {
        tbtensp.Text = ""; tbmota.Text = "";
        tbsize.Text = "";
        tbkm.Text = "";  tbgia.Text = ""; tbgiakm.Text = "";
        
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {

    }

    private void LayDanhMuc()
    {
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.DanhMucSanPham.Thongtin_danhmucsp();
        ddldanhmuc.Items.Clear();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddldanhmuc.Items.Add(new ListItem(dt.Rows[i]["TenDMSP"].ToString(), dt.Rows[i]["MaDMSP"].ToString()));
            //LayDanhMucCon(dt.Rows[i]["MaDM"].ToString(), "___");
        }
    }
}