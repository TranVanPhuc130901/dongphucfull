using System;
using System.Data;
using System.Web;

public partial class Areas_admin_Banner_Banner_ThemMoi : System.Web.UI.UserControl
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
            dt = DongPhucKhanhLinh.Banner.thongtin_banner_id(id);
            if (dt.Rows.Count > 0)
            {

                tbtenbanner.Text = dt.Rows[0]["TenBanner"].ToString();
                ltrAnhDaiDien.Text = "<img class='anhDaiDien'src='/pic/Banner/" + dt.Rows[0]["AnhBanner"] + @"'/>";
                hdTenAnhDaiDienCu.Value = dt.Rows[0]["AnhBanner"].ToString();
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
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/Banner/") + flAnhDaiDien.FileName);
                }
            }

            DongPhucKhanhLinh.Banner.banner_insert(flAnhDaiDien.FileName, tbtenbanner.Text);


            if (cbThemNhieuDanhMuc.Checked)
            {
                //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
                ResetControl();
            }

            else
            {
                //đẩy trang về trang danh sách các damnh mục đã tạo

                Response.Redirect("Admin.aspx?dm=banner&cn=hienthi");
            }
        }
        else
        {
            string tenAnhDaiDien = "";

            if (flAnhDaiDien.FileContent.Length > 0)
            {
                if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
                {
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/Banner/") + flAnhDaiDien.FileName);
                    tenAnhDaiDien = flAnhDaiDien.FileName;

                    // viết đoạn code xóa ảnh đại diện cũ tại đây - tạm thời chưa viết
                    string path = "pic/Banner";
                    System.IO.File.Delete(HttpContext.Current.Request.PhysicalApplicationPath + "/" + path + "/" + hdTenAnhDaiDienCu);

                }
            }

            if (tenAnhDaiDien == "")
            {
                tenAnhDaiDien = hdTenAnhDaiDienCu.Value;
            }

            DongPhucKhanhLinh.Banner.banner_Update(id, flAnhDaiDien.FileName, tbtenbanner.Text);

            //đẩy trang về trang danh sách các damnh mục đã tạo
            Response.Redirect("Admin.aspx?dm=banner&cn=hienthi");
        }



    }

    private void ResetControl()
    {

        tbtenbanner.Text = "";
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {

    }
}