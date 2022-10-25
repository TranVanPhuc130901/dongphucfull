using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_Client_SanPham_SanPhamClientControl : System.Web.UI.UserControl
{
    private string danhmucphu = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["danhmucphu"] != null)
            danhmucphu = Request.QueryString["danhmucphu"];
        switch (danhmucphu)
        {
            case "chitiet":
                plsanphamclient.Controls.Add(LoadControl("SanPham_ChiTiet.ascx"));
                break;
            case "giohang":
                plsanphamclient.Controls.Add(LoadControl("GioHang.ascx"));
                break;
            case "danhsach":
                plsanphamclient.Controls.Add(LoadControl("SanPham_DanhSach.ascx"));
                break;
            default:
                plsanphamclient.Controls.Add(LoadControl("SanPham_DanhMuc.ascx"));
                break;

        }

    }
}