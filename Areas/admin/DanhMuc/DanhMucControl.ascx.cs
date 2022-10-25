using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_DanhMuc_DanhMucControl : System.Web.UI.UserControl
{
    private string vt = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["vt"] != null)
            vt = Request.QueryString["vt"];
        switch (vt)
        {
            case "dmgioithieu":
                pldanhmuc.Controls.Add(LoadControl("DanhMucGT/DanhMucGT_Control.ascx"));
                break;
            case "dmsanpham":
                pldanhmuc.Controls.Add(LoadControl("DanhMucSP/DanhMucSP_Control.ascx"));
                break;
            case "dmsanphamcha":
                pldanhmuc.Controls.Add(LoadControl("DanhMucSanPhamCha/DanhMucSP_Control.ascx"));
                break;
            default:
                pldanhmuc.Controls.Add(LoadControl("DanhMucTin/DanhMucTinControl.ascx"));
                break;
        }

    }
}