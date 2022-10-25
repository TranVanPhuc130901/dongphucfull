using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_Client_KhachHang_KhachHangLienKet : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            khachhanglienket.Text = Khachhanglienket();
        }
    }

    private string Khachhanglienket()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.KhachHangLienKet.Thongtin_khachhanglienket();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            s += @"
             <a href='' class='item'>
                                <div class='WImage'>
                                    <img src ='/pic/KhachHangLienKet/"+dt.Rows[i]["AnhKHLienKet"]+@"' alt='' />
                                </div>
                                <div class='info'>
                                    <div class='name'>"+dt.Rows[i]["TenKHLienKet"]+@"</div>
                                    <div class='xemthem'>Xem Chi Tiết</div>
                                </div>
                            </a>
        ";
        }
        return s;
    }
}