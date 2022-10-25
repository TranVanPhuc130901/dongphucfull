using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_DanhMuc_DanhMucSP_DanhMucSP_Control : System.Web.UI.UserControl
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
                pldanhmucsp.Controls.Add(LoadControl("DanhMucSP_ThemMoi.ascx"));
                break;
            default:
                pldanhmucsp.Controls.Add(LoadControl("DanhMucSP_HienThi.ascx"));
                break;
        }

    }
}