using System;
public partial class Areas_admin_Menu_Ajax_UpdateActive : System.Web.UI.Page
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
        string MaMenu = "";
        string TrangThai = "";
        if (Request.Params["MaMenu"] != null)
            MaMenu = Request.Params["MaMenu"];
        if (Request.Params["TrangThai"] != null)
            TrangThai = Request.Params["TrangThai"];


        // thuc hien code xoa
        if(TrangThai == "True")
        {
            DongPhucKhanhLinh.Menu.menu_unactive(MaMenu, "false");
            Response.Write("2");
        } else
        {
            DongPhucKhanhLinh.Menu.menu_unactive(MaMenu, "true");
            Response.Write("1");
        }
        

        //1 - la thanh con 2 la chua thanh cong
        
    }
}