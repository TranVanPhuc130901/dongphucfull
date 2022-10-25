using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_DanhMuc_DanhMucSP_Ajax_XoaDanhMucSanPham : System.Web.UI.Page
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["thaotac"] != null)
            thaotac = Request.Params["thaotac"];

        switch (thaotac)
        {
            case "XoaDanhMucSanPham":
                XoaDanhMucSanPham();
                break;
        }

    }
    private void XoaDanhMucSanPham()
    {
        string MaDMCha = "";
        if (Request.Params["MaDMCha"] != null)
            MaDMCha = Request.Params["MaDMCha"];
       
        DongPhucKhanhLinh.danhmuccha.danhmuccha_del(MaDMCha);
        //string path = "pic/DanhMucSP";
        //System.IO.File.Delete(HttpContext.Current.Request.PhysicalApplicationPath + "/" + path + "/" + AnhSP);

        //1 - la thanh con 2 la chua thanh cong
        Response.Write("1");
    }
}