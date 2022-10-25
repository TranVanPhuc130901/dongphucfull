using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_Client_TinTuc_TinTucClientControl : System.Web.UI.UserControl
{
    private string danhmucphu = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["danhmucphu"] != null)
            danhmucphu = Request.QueryString["danhmucphu"];
        switch (danhmucphu)
        {
            case "chitiet":
                pltintuc.Controls.Add(LoadControl("TinTuc_ChiTiet.ascx"));
                break;
            case "danhsach":
                pltintuc.Controls.Add(LoadControl("TinTuc_DanhSach.ascx"));
                break;
            default:
                pltintuc.Controls.Add(LoadControl("TinTuc.ascx"));
                break;

        }

    }
}