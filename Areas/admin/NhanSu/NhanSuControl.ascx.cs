using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_NhanSu_NhanSuControl : System.Web.UI.UserControl
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
                plnhansu.Controls.Add(LoadControl("NhanSu_ThemMoi.ascx"));
                break;
            default:
                plnhansu.Controls.Add(LoadControl("NhanSu_HienThi.ascx"));
                break;
        }

    }
}