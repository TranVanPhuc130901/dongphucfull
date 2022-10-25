using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_AnhSP_Ajax_XoaAnhSP : System.Web.UI.Page
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["thaotac"] != null)
            thaotac = Request.Params["thaotac"];

        switch (thaotac)
        {
            case "XoaAnhSP":
                XoaAnhSP();
                break;
        }

    }
    private void XoaAnhSP()
    {
        string MaAnhSP = "";
        if (Request.Params["MaAnhSP"] != null)
            MaAnhSP = Request.Params["MaAnhSP"];

        // thuc hien code xoa
        DongPhucKhanhLinh.AnhSP.anhsp_del(MaAnhSP);

        //1 - la thanh con 2 la chua thanh cong
        Response.Write("1");
    }
}