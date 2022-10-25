using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_Banner_Ajax_UpdateActive : System.Web.UI.Page
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["thaotac"] != null)
            thaotac = Request.Params["thaotac"];

        switch (thaotac)
        {
            case "CapNhatTrangThai":
                CapNhatTrangThai();
                break;
        }

    }
    private void CapNhatTrangThai()
    {
        string MaBanner = "";
        string TrangThai = "";
        if (Request.Params["MaBanner"] != null)
            MaBanner = Request.Params["MaBanner"];
        if (Request.Params["TrangThai"] != null)
            TrangThai = Request.Params["TrangThai"];


        // thuc hien code xoa
        if (TrangThai == "True")
        {
            DongPhucKhanhLinh.Banner.banner_unactive(MaBanner, "false");
            Response.Write("2");
        }
        else
        {
            DongPhucKhanhLinh.Banner.banner_unactive(MaBanner, "true");
            Response.Write("1");
        }


        //1 - la thanh con 2 la chua thanh cong

    }
}