using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_Client_GioiThieu_GioiThieu_DanhSach : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
            litdanhsachgioithieu.Text = LayDanhSachGioiThieu();

        }
    }

    private string LayDanhSachGioiThieu()
    {
        
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.GioiThieu.Thongtin_gioithieu();
        for(int i = 0; i< dt.Rows.Count; i++)
        {
            s += @"
   <a href='/default.aspx?dm=gioi-thieu&danhmucphu=chitiet&id="+dt.Rows[i]["MaGioiThieu"]+@"' class='item'>
                            <div class='WImage'>
                                <img src='/pic/GioiThieu/"+dt.Rows[i]["AnhGT"]+@"' alt='' />
                                <div class='layer'></div>
                            </div>
                            <div class='text'>
                                <div class='title_i'>"+dt.Rows[i]["TenGioiThieu"]+@"</div>
                                <div class='viewdate'>
                                    <div class='date'>Ngày đăng: "+dt.Rows[i]["NgayTao"]+@"</div>
                                    <div class='view'>"+dt.Rows[i]["LuotXem"]+@" Lượt xem</div>
                                </div>
                                <div class='decs'>
                                    "+dt.Rows[i]["MoTa"]+@"
                                </div>
                                <div class='btn'>Xem Ngay</div>
                            </div>
                        </a>
";
        }
        return s;
    }

   
}