using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_Client_GioiThieu_GioiThieu_ChiTiet : System.Web.UI.UserControl
{
    string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null) 
            id = Request.QueryString["id"];
        if (!IsPostBack)
        {
            litgioithieuchitiet.Text = LayChiTietGioiThieu();
            litdanhmucgioithieukhac.Text = LayDanhMucKhac();
            litdanhmucsp.Text = LayDanhMucSP();
        }

    }
    private string LayDanhMucSP()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.DanhMucGioiThieu.Thongtin_danhmucgt();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            s += @"
    <div class='item_drop'>

                    <div class='title_drop " + dt.Rows[i]["MaDMGT"] + @"'> 
                        " + dt.Rows[i]["TenDMGT"] + @"
";
            s += Layimg(dt.Rows[i]["MaDMGT"].ToString());

            s += @"         
                    </div>
                    <hr />
                <div class='dropdown_list'>";
            s += LayDanhMucCon(dt.Rows[i]["MaDMGT"].ToString());
            s += @"
                    </div>
                </div>

";
        }
        return s;
    }

    private string LayDanhMucCon(string madmcha)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.GioiThieu.thongtin_gioithieu_madmcha(madmcha);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            s += @"
                    <a href='/default.aspx?dm=gioi-thieu&danhmucphu=chitiet&id=" + dt.Rows[i]["MaGioiThieu"] + @"' class='danhsach'>
                            <div class='ten'>" + dt.Rows[i]["TenGioiThieu"] + @"</div>
";
            s += @"
                            
                        </a>
";
        }
        return s;
    }
    private string Layimg(string madmcha)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.GioiThieu.thongtin_gioithieu_madmcha(madmcha);
        if (dt.Rows.Count > 0)
        {
            s += @"
 <img class='imgup active' src='../../../../style/client/img/icon/down_sp.png'/>
<img class='imgdown' src='../../../../style/client/img/icon/down_click.png'/>
";
        }
        else
        {

        }
        return s;
    }
    private string LayDanhMucKhac()
    {
        string s = "";
        DataTable dt = new DataTable();
      dt =  DongPhucKhanhLinh.GioiThieu.Thongtin_gioithieu();
        for(int i = 0; i<dt.Rows.Count; i++)
        {
            if(dt.Rows[i]["MaGioiThieu"].ToString() != id) {
                s += @" <a href='/default.aspx?dm=gioi-thieu&danhmucphu=chitiet&id=" + dt.Rows[i]["MaGioiThieu"] + @"' class='item'>" + dt.Rows[i]["TenGioiThieu"] + @"</a> ";
            }
            
        }
        return s;
    }

    private string LayChiTietGioiThieu()
    {
        layluotxem();
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.GioiThieu.thongtin_gioithieu_id(id);
        if (dt.Rows.Count > 0)
        {
            s += @"
                    <div class='title'>"+dt.Rows[0]["TenGioiThieu"]+@"</div>
                    <div class='dateview'>
                        <div class='date'>Ngày đăng: "+dt.Rows[0]["NgayTao"]+@"</div>
                        <div class='view'>Lượt xem: "+dt.Rows[0]["LuotXem"]+@" lượt xem</div>
                    </div>
                    
                    <div class='decs'> "+dt.Rows[0]["ChiTiet"]+@"
                    </div>
                   
";
        }
        return s;
    }

    private void layluotxem()
    {

        DongPhucKhanhLinh.GioiThieu.CapNhatLuotXemGioiThieu(id);
   
    }
}