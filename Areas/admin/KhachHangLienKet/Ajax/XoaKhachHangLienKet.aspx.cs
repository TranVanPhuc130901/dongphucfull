using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_KhachHangLienKet_Ajax_XoaKhachHangLienKet : System.Web.UI.Page
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["thaotac"] != null)
            thaotac = Request.Params["thaotac"];

        switch (thaotac)
        {
            case "XoaKhachHangLienKet":
                XoaKhachHangLienKet();
                break;
        }

    }
    private void XoaKhachHangLienKet()
    {
        string MaKHLienKet = "";
        if (Request.Params["MaKHLienKet"] != null)
            MaKHLienKet = Request.Params["MaKHLienKet"];

        // thuc hien code xoa
        DongPhucKhanhLinh.KhachHangLienKet.khachhanglienket_del(MaKHLienKet);

        //1 - la thanh con 2 la chua thanh cong
        Response.Write("1");
    }
}