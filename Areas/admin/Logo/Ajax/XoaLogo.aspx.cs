using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_Logo_Ajax_XoaLogo : System.Web.UI.Page
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["thaotac"] != null)
            thaotac = Request.Params["thaotac"];

        switch (thaotac)
        {
            case "XoaLogo":
                XoaThaoTac();
                break;
        }

    }
    private void XoaThaoTac()
    {
        string MaLogo = "";
        if (Request.Params["MaLogo"] != null)
            MaLogo = Request.Params["MaLogo"];

        // thuc hien code xoa
        DongPhucKhanhLinh.Logo.logo_del(MaLogo);

        //1 - la thanh con 2 la chua thanh cong
        Response.Write("1");
    }
}