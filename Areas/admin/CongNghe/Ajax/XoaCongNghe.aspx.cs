using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_CongNghe_Ajax_XoaCongNghe : System.Web.UI.Page
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["thaotac"] != null)
            thaotac = Request.Params["thaotac"];

        switch (thaotac)
        {
            case "XoaCongNghe":
                XoaThaoTac();
                break;
        }

    }
    private void XoaThaoTac()
    {
        string MaCN = "";
        if (Request.Params["MaCN"] != null)
            MaCN = Request.Params["MaCN"];

        // thuc hien code xoa
        DongPhucKhanhLinh.CongNghe.congnghe_del(MaCN);

        //1 - la thanh con 2 la chua thanh cong
        Response.Write("1");
    }
}