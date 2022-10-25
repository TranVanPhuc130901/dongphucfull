using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_GioiThieu_GioiThieu_ThemMoi : System.Web.UI.UserControl
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
            LayDanhMucGioiThieu();
        }
    }

    private void LayDanhMucGioiThieu()
    {
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.DanhMucGioiThieu.Thongtin_danhmucgt();
        ddlmagioithieu.Items.Clear();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlmagioithieu.Items.Add(new ListItem(dt.Rows[i]["TenDMGT"].ToString(), dt.Rows[i]["MaDMGT"].ToString()));
            
        }
    }

    private void HienThiThongTin(string id)
    {
        if (cn == "sua")
        {
            btThemMoi.Text = "Chỉnh Sửa";
            DataTable dt = new DataTable();
            dt = DongPhucKhanhLinh.GioiThieu.thongtin_gioithieu_id(id);
            if (dt.Rows.Count > 0)
            {

                tbtengt.Text = dt.Rows[0]["TenGioiThieu"].ToString();

                tbluotxem.Text = dt.Rows[0]["LuotXem"].ToString();
                tbmota.Text = dt.Rows[0]["MoTa"].ToString();
                ddlmagioithieu.SelectedValue = dt.Rows[0]["MaDMGT"].ToString();
                ltrAnhDaiDien.Text = "<img class='anhDaiDien'src='/pic/GioiThieu/" + dt.Rows[0]["AnhGT"] + @"'/>";
                hdTenAnhDaiDienCu.Value = dt.Rows[0]["AnhGT"].ToString();
                tbchitiet.Text = dt.Rows[0]["ChiTiet"].ToString();
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
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/GioiThieu/") + flAnhDaiDien.FileName);
                }
            }

            var ngaytao = tbngaytao.Text = DateTime.Now.ToString("MM/dd/yyyy");
            DongPhucKhanhLinh.GioiThieu.gioithieu_insert(tbtengt.Text, ngaytao, tbluotxem.Text,tbmota.Text, ddlmagioithieu.SelectedValue, flAnhDaiDien.FileName, tbchitiet.Text);


            if (cbThemNhieuDanhMuc.Checked)
            {
                //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
                ResetControl();
            }

            else
            {
                //đẩy trang về trang danh sách các damnh mục đã tạo

                Response.Redirect("Admin.aspx?dm=gioithieu&cn=hienthi");
            }
        }
        else
        {
            string tenAnhDaiDien = "";

            if (flAnhDaiDien.FileContent.Length > 0)
            {
                if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
                {
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/GioiThieu/") + flAnhDaiDien.FileName);
                    tenAnhDaiDien = flAnhDaiDien.FileName;

                    // viết đoạn code xóa ảnh đại diện cũ tại đây - tạm thời chưa viết
                }
            }

            if (tenAnhDaiDien == "")
            {
                tenAnhDaiDien = hdTenAnhDaiDienCu.Value;
            }

            var ngaytao = tbngaytao.Text = DateTime.Now.ToString("MM/dd/yyyy");
            DongPhucKhanhLinh.GioiThieu.gioithieu_Update( id,tbtengt.Text, ngaytao, tbluotxem.Text, tbmota.Text, ddlmagioithieu.SelectedValue, flAnhDaiDien.FileName, tbchitiet.Text);
            //đẩy trang về trang danh sách các damnh mục đã tạo
            Response.Redirect("Admin.aspx?dm=gioithieu&cn=hienthi");
        }



    }

    private void ResetControl()
    {

        tbtengt.Text = "";
        tbngaytao.Text = "";
        tbluotxem.Text = "";
        tbmota.Text = "";
        tbchitiet.Text = "";
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {

    }
}