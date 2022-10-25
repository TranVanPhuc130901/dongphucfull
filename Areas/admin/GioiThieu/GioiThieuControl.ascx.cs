using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_GioiThieu_GioiThieuControl : System.Web.UI.UserControl
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
                plgioithieu.Controls.Add(LoadControl("GioiThieu_ThemMoi.ascx"));
                break;
            default:
                plgioithieu.Controls.Add(LoadControl("GioiThieu_HienThi.ascx"));
                break;
        }

    }
}