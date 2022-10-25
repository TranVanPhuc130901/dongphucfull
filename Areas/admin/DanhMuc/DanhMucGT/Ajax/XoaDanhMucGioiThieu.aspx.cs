using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_DanhMuc_DanhMucGT_Ajax_XoaDanhMucGioiThieu : System.Web.UI.Page
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["thaotac"] != null)
            thaotac = Request.Params["thaotac"];

        switch (thaotac)
        {
            case "XoaDanhMucGioiThieu":
                XoaDanhMucGioiThieu();
                break;
        }

    }
    private void XoaDanhMucGioiThieu()
    {
        string MaDMGT = "";
        if (Request.Params["MaDMGT"] != null)
            MaDMGT = Request.Params["MaDMGT"];

        // thuc hien code xoa
        DongPhucKhanhLinh.DanhMucGioiThieu.danhmucgioithieu_del(MaDMGT);

        //1 - la thanh con 2 la chua thanh cong
        Response.Write("1");
    }
}