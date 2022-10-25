using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_NhanSu_Ajax_XoaNhanSu : System.Web.UI.Page
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["thaotac"] != null)
            thaotac = Request.Params["thaotac"];

        switch (thaotac)
        {
            case "XoaNhanSu":
                XoaNhanSu();
                break;
        }

    }
    private void XoaNhanSu()
    {
        string MaNhanSu = "";
        if (Request.Params["MaNhanSu"] != null)
            MaNhanSu = Request.Params["MaNhanSu"];

        // thuc hien code xoa
        DongPhucKhanhLinh.NhanSu.nhansu_del(MaNhanSu);

        //1 - la thanh con 2 la chua thanh cong
        Response.Write("1");
    }
}