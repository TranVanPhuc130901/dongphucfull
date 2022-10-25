using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_DanhMuc_DanhMucSP_DanhMucSP_ThemMoi : System.Web.UI.UserControl
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
            dt = DongPhucKhanhLinh.DanhMucSanPham.thongtin_danhmucsp_id(id);
            if (dt.Rows.Count > 0)
            {

                tbdanhmucsp.Text = dt.Rows[0]["TenDMSP"].ToString();
                ltrAnhDaiDien.Text = "<img class='anhDaiDien'src='/pic/DanhMucSP/" + dt.Rows[0]["AnhDM"] + @"'/>";
                hdTenAnhDaiDienCu.Value = dt.Rows[0]["AnhDM"].ToString();
                tblink.Text = dt.Rows[0]["Link"].ToString();
                ddldanhmuc.SelectedValue = dt.Rows[0]["MaDmCha"].ToString();
                tbmotatin.Text = dt.Rows[0]["MoTa"].ToString();
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
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/DanhMucSP/") + flAnhDaiDien.FileName);
                }
            }

            DongPhucKhanhLinh.DanhMucSanPham.danhmucsp_insert(tbdanhmucsp.Text, flAnhDaiDien.FileName, tblink.Text, ddldanhmuc.SelectedValue, tbmotatin.Text);


            if (cbThemNhieuDanhMuc.Checked)
            {
                //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
                ResetControl();
            }

            else
            {
                //đẩy trang về trang danh sách các damnh mục đã tạo

                Response.Redirect("Admin.aspx?dm=danhmuc&vt=dmsanpham&cn=hienthi");
            }
        }
        else
        {
            string tenAnhDaiDien = "";

            if (flAnhDaiDien.FileContent.Length > 0)
            {
                if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
                {
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/DanhMucSP/") + flAnhDaiDien.FileName);
                    tenAnhDaiDien = flAnhDaiDien.FileName;

                    // viết đoạn code xóa ảnh đại diện cũ tại đây - tạm thời chưa viết
                }
            }

            if (tenAnhDaiDien == "")
            {
                tenAnhDaiDien = hdTenAnhDaiDienCu.Value;
            }


            DongPhucKhanhLinh.DanhMucSanPham.danhmucsp_Update(id, tbdanhmucsp.Text, flAnhDaiDien.FileName, tblink.Text, ddldanhmuc.SelectedValue, tbmotatin.Text);

            //đẩy trang về trang danh sách các damnh mục đã tạo
            Response.Redirect("Admin.aspx?dm=danhmuc&vt=dmsanpham&cn=hienthi");
        }



    }

    private void ResetControl()
    {

        tbdanhmucsp.Text = "";
        tbmotatin.Text = "";
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {

    }
    private void LayDanhMuc()
    {
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.danhmuccha.Thongtin_danhmuccha();
        ddldanhmuc.Items.Clear();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddldanhmuc.Items.Add(new ListItem(dt.Rows[i]["TenDMCha"].ToString(), dt.Rows[i]["MaDMCha"].ToString()));
            //LayDanhMucCon(dt.Rows[i]["MaDM"].ToString(), "___");
        }
    }
}