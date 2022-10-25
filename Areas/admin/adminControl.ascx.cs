using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_adminControl : System.Web.UI.UserControl
{
    private string dm = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["dm"] != null) 
        dm = Request.QueryString["dm"];
        switch (dm)
        {
            case "sanpham":
                pladmin.Controls.Add(LoadControl("SanPham/SanPhamControl.ascx"));
                break;
            case "anhsanpham":
                pladmin.Controls.Add(LoadControl("AnhSP/AnhSPControl.ascx"));
                break;
            case "taikhoan":
                pladmin.Controls.Add(LoadControl("TaiKhoan/TaiKhoanControl.ascx"));
                break;
            case "tintuc":
                pladmin.Controls.Add(LoadControl("TinTuc/TinTucControl.ascx"));
                break;
            case "menu":
                pladmin.Controls.Add(LoadControl("Menu/MenuControl.ascx"));
                break;
            case "banner":
                pladmin.Controls.Add(LoadControl("Banner/BannerControl.ascx"));
                break;
            case "danhmuc":
                pladmin.Controls.Add(LoadControl("DanhMuc/DanhMucControl.ascx"));
                break;
            case "logo":
                pladmin.Controls.Add(LoadControl("Logo/LogoControl.ascx"));
                break;
            case "congnghe":
                pladmin.Controls.Add(LoadControl("CongNghe/CongNgheControl.ascx"));
                break;
            case "thongtincuahang":
                pladmin.Controls.Add(LoadControl("DanhSachCuaHang/DanhSachCuaHangControl.ascx"));
                break;
            case "gioithieu":
                pladmin.Controls.Add(LoadControl("GioiThieu/GioiThieuControl.ascx"));
                break;
            case "hotro":
                pladmin.Controls.Add(LoadControl("HoTro/HoTroControl.ascx"));
                break;
            case "khachhangdanhgia":
                pladmin.Controls.Add(LoadControl("KhachHangDanhGia/KhachHangDanhGiaControl.ascx"));
                break;
            case "khachhanglienket":
                pladmin.Controls.Add(LoadControl("KhachHangLienKet/KhachHangLienKetControl.ascx"));
                break;
            case "nhansu":
                pladmin.Controls.Add(LoadControl("NhanSu/NhanSuControl.ascx"));
                break;
            default:
                pladmin.Controls.Add(LoadControl("Menu/MenuControl.ascx"));
                break;
        }

    }
    
}