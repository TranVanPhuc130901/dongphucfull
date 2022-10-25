using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_Menu_MenuControl : System.Web.UI.UserControl
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
                plmenu.Controls.Add(LoadControl("Menu_ThemMoi.ascx"));
                break;
            default:
                plmenu.Controls.Add(LoadControl("Menu_HienThi.ascx"));
                break;
        }

    }
}
