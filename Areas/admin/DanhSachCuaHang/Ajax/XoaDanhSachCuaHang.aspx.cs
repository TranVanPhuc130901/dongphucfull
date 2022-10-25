using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_DanhSachCuaHang_Ajax_XoaDanhSachCuaHang : System.Web.UI.Page
{

    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["thaotac"] != null)
            thaotac = Request.Params["thaotac"];

        switch (thaotac)
        {
            case "XoaDanhSachCuaHang":
                XoaDanhSachCuaHang();
                break;
        }

    }
    private void XoaDanhSachCuaHang()
    {
        string MaCuaHang = "";
        if (Request.Params["MaCuaHang"] != null)
            MaCuaHang = Request.Params["MaCuaHang"];

        // thuc hien code xoa
        DongPhucKhanhLinh.DanhSachCuaHang.danhsachcuahang_del(MaCuaHang);

        //1 - la thanh con 2 la chua thanh cong
        Response.Write("1");
    }
}