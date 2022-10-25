using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_TinTuc_Ajax_XoaTinTuc : System.Web.UI.Page
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["thaotac"] != null)
            thaotac = Request.Params["thaotac"];

        switch (thaotac)
        {
            case "XoaTinTuc":
                XoaTinTuc();
                break;
        }

    }
    private void XoaTinTuc()
    {
        string MaTinTuc = "";
        if (Request.Params["MaTinTuc"] != null)
            MaTinTuc = Request.Params["MaTinTuc"];

        // thuc hien code xoa
        DongPhucKhanhLinh.TinTuc.tintuc_del(MaTinTuc);

        //1 - la thanh con 2 la chua thanh cong
        Response.Write("1");
    }
}