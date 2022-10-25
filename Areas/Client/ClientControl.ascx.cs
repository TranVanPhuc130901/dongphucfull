using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_Client_ClientControl : System.Web.UI.UserControl
{
    private string dm = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["dm"] != null)
            dm = Request.QueryString["dm"];
        switch(dm)
        {
            case "san-pham":
                plclient.Controls.Add(LoadControl("SanPham/SanPhamControl.ascx"));
                break;
            case "gioi-thieu":
                plclient.Controls.Add(LoadControl("GioiThieu/GioiThieuControl.ascx"));
                break;
            case "tin-tuc":
                plclient.Controls.Add(LoadControl("TinTuc/TinTucControl.ascx"));
                break;
            case "khach-hang":
                plclient.Controls.Add(LoadControl("KhachHang/KhachHangControl.ascx"));
                break;
            case "lien-ket":
                plclient.Controls.Add(LoadControl("KhachHang/KhachHangControl.ascx"));
                break;
            case "lien-he":
                plclient.Controls.Add(LoadControl("LienHe/LienHeControl.ascx"));
                break;
            default:
                plclient.Controls.Add(LoadControl("TrangChu/TrangChuControl.ascx"));
                break;

        }

    }
}