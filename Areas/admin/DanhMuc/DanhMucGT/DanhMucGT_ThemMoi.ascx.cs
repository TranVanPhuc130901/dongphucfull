using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_DanhMuc_DanhMucGT_DanhMucGT_ThemMoi : System.Web.UI.UserControl
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
            dt = DongPhucKhanhLinh.DanhMucGioiThieu.thongtin_danhmucgt_id(id);
            if (dt.Rows.Count > 0)
            {

                tbdanhmucgt.Text = dt.Rows[0]["TenDMGT"].ToString();
                tblink.Text = dt.Rows[0]["link"].ToString();
               
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


            DongPhucKhanhLinh.DanhMucGioiThieu.danhmucgt_insert(tbdanhmucgt.Text, tblink.Text);


            if (cbThemNhieuDanhMuc.Checked)
            {
                //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
                ResetControl();
            }

            else
            {
                //đẩy trang về trang danh sách các damnh mục đã tạo

                Response.Redirect("Admin.aspx?dm=danhmuc&vt=dmgioithieu&cn=hienthi");
            }
        }
        else
        {


            DongPhucKhanhLinh.DanhMucGioiThieu.danhmucgt_Update(id, tbdanhmucgt.Text, tblink.Text);

            //đẩy trang về trang danh sách các damnh mục đã tạo
            Response.Redirect("Admin.aspx?dm=danhmuc&vt=dmgioithieu&cn=hienthi");
        }



    }

    private void ResetControl()
    {

        tbdanhmucgt.Text = "";
        tblink.Text = "";
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {

    }
}