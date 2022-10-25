using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_TinTuc_TinTuc_ThemMoi : System.Web.UI.UserControl
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
            LayDanhMucTin();
        }
    }

    private void LayDanhMucTin()
    {
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.DanhMucTin.Thongtin_danhmuctin();
        ddltintuc.Items.Clear();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddltintuc.Items.Add(new ListItem(dt.Rows[i]["TenDMTin"].ToString(), dt.Rows[i]["MaDMTin"].ToString()));
            //LayDanhMucCon(dt.Rows[i]["MaDM"].ToString(), "___");
        }
    }

    private void HienThiThongTin(string id)
    {
        if (cn == "sua")
        {
            btThemMoi.Text = "Chỉnh Sửa";
            DataTable dt = new DataTable();
            dt = DongPhucKhanhLinh.TinTuc.thongtin_tintuc_id(id);
            if (dt.Rows.Count > 0)
            {

                tbtentintuc.Text = dt.Rows[0]["TenTinTuc"].ToString();
                tbmota.Text = dt.Rows[0]["MoTa"].ToString();
                ddltintuc.SelectedValue = dt.Rows[0]["MaDMTin"].ToString();
                tbngaytao.Text = dt.Rows[0]["NgayTao"].ToString();
                tbluotxem.Text = dt.Rows[0]["LuotXem"].ToString();
                tblink.Text = dt.Rows[0]["Link"].ToString();
                ltrAnhDaiDien.Text = "<img class='anhDaiDien'src='/pic/TinTuc/" + dt.Rows[0]["AnhTinTuc"] + @"'/>";
                hdTenAnhDaiDienCu.Value = dt.Rows[0]["AnhTinTuc"].ToString();
                tbchitiettin.Text = dt.Rows[0]["ChiTietTin"].ToString();
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
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/TinTuc/") + flAnhDaiDien.FileName);
                }
            }
            var ngaytao = tbngaytao.Text = DateTime.Now.ToString("MM/dd/yyyy");
            DongPhucKhanhLinh.TinTuc.tintuc_insert(tbtentintuc.Text, tbmota.Text, ddltintuc.SelectedValue, ngaytao, tbluotxem.Text, tblink.Text, flAnhDaiDien.FileName, tbchitiettin.Text);


            if (cbThemNhieuDanhMuc.Checked)
            {
                //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
                ResetControl();
            }

            else
            {
                //đẩy trang về trang danh sách các damnh mục đã tạo

                Response.Redirect("Admin.aspx?dm=tintuc&cn=hienthi");
            }
        }
        else
        {
            string tenAnhDaiDien = "";

            if (flAnhDaiDien.FileContent.Length > 0)
            {
                if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
                {
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/TinTuc/") + flAnhDaiDien.FileName);
                    tenAnhDaiDien = flAnhDaiDien.FileName;


                    // viết đoạn code xóa ảnh đại diện cũ tại đây - tạm thời chưa viết
                }
            }

            if (tenAnhDaiDien == "")
            {
                tenAnhDaiDien = hdTenAnhDaiDienCu.Value;
            }


            var ngaytao = tbngaytao.Text = DateTime.Now.ToString("MM/dd/yyyy");
            DongPhucKhanhLinh.TinTuc.tintuc_Update(id, tbtentintuc.Text, tbmota.Text, ddltintuc.SelectedValue, ngaytao, tbluotxem.Text, tblink.Text, flAnhDaiDien.FileName, tbchitiettin.Text);

            //đẩy trang về trang danh sách các damnh mục đã tạo
            Response.Redirect("Admin.aspx?dm=tintuc&cn=hienthi");
        }



    }

    private void ResetControl()
    {

        tbtentintuc.Text = "";
        tbmota.Text = "";
        tbngaytao.Text = "";
        tbluotxem.Text = "";
        tblink.Text = "";
        tbchitiettin.Text = "";
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {

    }
}