using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_KhachHangDanhGia_Ajax_XoaKhachHangDanhGia : System.Web.UI.Page
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["thaotac"] != null)
            thaotac = Request.Params["thaotac"];

        switch (thaotac)
        {
            case "XoaKhachHangDanhGia":
                XoaKhachHangDanhGia();
                break;
        }

    }
    private void XoaKhachHangDanhGia()
    {
        string MaDanhGia = "";
        if (Request.Params["MaDanhGia"] != null)
            MaDanhGia = Request.Params["MaDanhGia"];

        // thuc hien code xoa
        DongPhucKhanhLinh.KhachHangDanhGia.khachhangdanhgia_del(MaDanhGia);

        //1 - la thanh con 2 la chua thanh cong
        Response.Write("1");
    }
}