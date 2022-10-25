using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_Client_GioiThieu_GioiThieuControl : System.Web.UI.UserControl
{
    string danhmucphu = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["danhmucphu"] != null)
            danhmucphu = Request.QueryString["danhmucphu"];
        switch (danhmucphu)
        {
            case "chitiet":
                plgioithieu.Controls.Add(LoadControl("GioiThieu_ChiTiet.ascx"));
                break;
            case "vechungtoi":
                plgioithieu.Controls.Add(LoadControl("GioiThieuVeChungToi.ascx"));
                break;
            default:
                plgioithieu.Controls.Add(LoadControl("GioiThieu_DanhSach.ascx"));
                break;
        }
    }
}