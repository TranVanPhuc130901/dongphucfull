using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_DanhMuc_DanhMucTin_DanhMucTin_ThemMoi : System.Web.UI.UserControl
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
            dt = DongPhucKhanhLinh.DanhMucTin.thongtin_danhmuctin_id(id);
            if (dt.Rows.Count > 0)
            {

                tbdanhmuctin.Text = dt.Rows[0]["TenDMTin"].ToString();

            }
            else
            {
                btThemMoi.Text = "Thêm Mới";
                cbThemNhieuDanhMuc.Visible = true;
                ddldanhmuc.SelectedValue = dt.Rows[0]["MaDmCha"].ToString();

            }
        }
    }

    protected void btThemMoi_Click(object sender, EventArgs e)
    {
        if (cn == "themmoi")
        {


            DongPhucKhanhLinh.DanhMucTin.danhmuctin_insert(tbdanhmuctin.Text, ddldanhmuc.SelectedValue);


            if (cbThemNhieuDanhMuc.Checked)
            {
                //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
                ResetControl();
            }

            else
            {
                //đẩy trang về trang danh sách các damnh mục đã tạo

                Response.Redirect("Admin.aspx?dm=danhmuc&vt=danhmuctin&cn=hienthi");
            }
        }
        else
        {
 DongPhucKhanhLinh.DanhMucTin.danhmuctin_Update(id, tbdanhmuctin.Text, ddldanhmuc.SelectedValue);

            //đẩy trang về trang danh sách các damnh mục đã tạo
            Response.Redirect("Admin.aspx?dm=danhmuc&vt=danhmuctin&cn=hienthi");
        }



    }

    private void ResetControl()
    {

        tbdanhmuctin.Text = "";
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {

    }
    private void LayDanhMuc()
    {
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.danhmuctincha.Thongtin_danhmuccha();
        ddldanhmuc.Items.Clear();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddldanhmuc.Items.Add(new ListItem(dt.Rows[i]["TenDMTinCha"].ToString(), dt.Rows[i]["MaDMTinCha"].ToString()));
            //LayDanhMucCon(dt.Rows[i]["MaDM"].ToString(), "___");
        }
    }
}