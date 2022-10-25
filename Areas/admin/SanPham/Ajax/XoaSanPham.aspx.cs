using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_SanPham_Ajax_XoaSanPham : System.Web.UI.Page
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["thaotac"] != null)
            thaotac = Request.Params["thaotac"];

        switch (thaotac)
        {
            case "XoaSanPham":
                XoaSanPham();
                break;
        }

    }
    private void XoaSanPham()
    {
        string MaSP = "";
        string AnhSP = "";
        if (Request.Params["MaSP"] != null)
            MaSP = Request.Params["MaSP"];
        if (Request.Params["AnhSP"] != null)
            AnhSP = Request.Params["AnhSP"];

        // thuc hien code xoa
        DongPhucKhanhLinh.SanPham.sanpham_del(MaSP);
        string path = "pic/SanPham";
        System.IO.File.Delete(HttpContext.Current.Request.PhysicalApplicationPath + "/" + path + "/" + AnhSP);

        //1 - la thanh con 2 la chua thanh cong
        Response.Write("1");
    }
}