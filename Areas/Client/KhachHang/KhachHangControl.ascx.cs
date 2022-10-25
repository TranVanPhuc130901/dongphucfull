using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_Client_KhachHang_KhachHangControl : System.Web.UI.UserControl
{
    private string danhmucphu = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["danhmucphu"] != null)
            danhmucphu = Request.QueryString["danhmucphu"];
        switch (danhmucphu)
        {
            case "danhgia":
                plkhachhang.Controls.Add(LoadControl("KhachHangDanhGia.ascx"));
                break;
            case "lienket":
                plkhachhang.Controls.Add(LoadControl("KhachHangLienKet.ascx"));
                break;

        }

    }
}