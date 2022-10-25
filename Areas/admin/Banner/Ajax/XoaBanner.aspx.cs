using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_Banner_Ajax_XoaBanner : System.Web.UI.Page
{

    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Form["thaotac"] != null)
            thaotac = Request.Form["thaotac"];

        switch (thaotac)
        {
            case "XoaBanner":
                XoaThaoTac();
                break;
        }

    }
    private void XoaThaoTac()
    {
        string MaBanner = "";
        string AnhBanner = "";
        if (Request.Form["MaBanner"] != null)
            MaBanner = Request.Form["MaBanner"];
        if (Request.Form["AnhBanner"] != null)
            AnhBanner = Request.Form["AnhBanner"];

        // thuc hien code xoa
        DongPhucKhanhLinh.Banner.banner_del(MaBanner);
        //DongPhucKhanhLinh.Banner.banner_del_img(AnhBanner);
        string path = "pic/Banner";
        System.IO.File.Delete(HttpContext.Current.Request.PhysicalApplicationPath + "/" + path + "/" + AnhBanner );

        //1 - la thanh con 2 la chua thanh cong
        Response.Write("1");
    }
}
