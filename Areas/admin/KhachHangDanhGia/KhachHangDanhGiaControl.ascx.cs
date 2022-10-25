using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_KhachHangDanhGia_KhachHangDanhGiaControl : System.Web.UI.UserControl
{
    private string cn = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["cn"] != null)
            cn = Request.QueryString["cn"];
        switch (cn)
        {
            case "themmoi":
            case "sua":
                plkhachangdanhgia.Controls.Add(LoadControl("KhachHangDanhGia_ThemMoi.ascx"));
                break;
            default:
                plkhachangdanhgia.Controls.Add(LoadControl("KhachHangDanhGia_HienThi.ascx"));
                break;
        }

    }
}