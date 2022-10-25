using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_TinTuc_TinTucControl : System.Web.UI.UserControl
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
                pltintuc.Controls.Add(LoadControl("TinTuc_ThemMoi.ascx"));
                break;
            default:
                pltintuc.Controls.Add(LoadControl("TinTuc_HienThi.ascx"));
                break;
        }

    }
}