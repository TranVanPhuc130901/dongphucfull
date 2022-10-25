using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_GioiThieu_Ajax_XoaGioiThieu : System.Web.UI.Page
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["thaotac"] != null)
            thaotac = Request.Params["thaotac"];

        switch (thaotac)
        {
            case "XoaGioiThieu":
                XoaGioiThieu();
                break;
        }

    }
    private void XoaGioiThieu()
    {
        string MaGioiThieu = "";
        if (Request.Params["MaGioiThieu"] != null)
            MaGioiThieu = Request.Params["MaGioiThieu"];

        // thuc hien code xoa
        DongPhucKhanhLinh.GioiThieu.gioithieu_del(MaGioiThieu);

        //1 - la thanh con 2 la chua thanh cong
        Response.Write("1");
    }
}