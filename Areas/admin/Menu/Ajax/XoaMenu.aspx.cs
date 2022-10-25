using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_Menu_Ajax_XoaMenu : System.Web.UI.Page
{
         private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["thaotac"] != null)
            thaotac = Request.Params["thaotac"];

        switch (thaotac)
        {
            case "XoaMenu":
                XoaThaoTac();
                break;
        }

    }
    private void XoaThaoTac()
    {
        string MaMenu = "";
        if (Request.Params["MaMenu"] != null)
            MaMenu = Request.Params["MaMenu"];

        // thuc hien code xoa
        DongPhucKhanhLinh.Menu.menu_del(MaMenu);

        //1 - la thanh con 2 la chua thanh cong
        Response.Write("1");
    }
}
