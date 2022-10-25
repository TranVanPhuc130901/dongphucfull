using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_HoTro_Ajax_XoaHoTro : System.Web.UI.Page
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["thaotac"] != null)
            thaotac = Request.Params["thaotac"];

        switch (thaotac)
        {
            case "XoaHoTro":
                XoaHoTro();
                break;
        }

    }
    private void XoaHoTro()
    {
        string MaHoTro = "";
        if (Request.Params["MaHoTro"] != null)
            MaHoTro = Request.Params["MaHoTro"];

        // thuc hien code xoa
        DongPhucKhanhLinh.HoTro.hotro_del(MaHoTro);

        //1 - la thanh con 2 la chua thanh cong
        Response.Write("1");
    }
}