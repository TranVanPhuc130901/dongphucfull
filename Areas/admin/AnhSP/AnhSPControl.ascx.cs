using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_AnhSP_AnhSPControl : System.Web.UI.UserControl
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
                planhsp.Controls.Add(LoadControl("AnhSP_ThemMoi.ascx"));
                break;
            default:
                planhsp.Controls.Add(LoadControl("AnhSP_HienThi.ascx"));
                break;
        }

    }
}