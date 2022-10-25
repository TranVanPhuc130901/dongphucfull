using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_DanhMuc_DanhMucTin_Ajax_XoaDanhMucTin : System.Web.UI.Page
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["thaotac"] != null)
            thaotac = Request.Params["thaotac"];

        switch (thaotac)
        {
            case "XoaDanhMucTin":
                XoaDanhMucTin();
                break;
        }

    }
    private void XoaDanhMucTin()
    {
        string MaDMTin = "";
        if (Request.Params["MaDMTin"] != null)
            MaDMTin = Request.Params["MaDMTin"];

        // thuc hien code xoa
        DongPhucKhanhLinh.DanhMucTin.danhmuctin_del(MaDMTin);

        //1 - la thanh con 2 la chua thanh cong
        Response.Write("1");
    }
}