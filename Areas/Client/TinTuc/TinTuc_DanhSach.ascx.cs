using Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_Client_TinTuc_TinTuc_DanhSach : System.Web.UI.UserControl
{
    string id = "";
    string _p = "1";
    protected void Page_Load(object sender, EventArgs e)
    {
          if (Request.Params["p"] != null) _p = Request.Params["p"];
        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"]; 
        if (!IsPostBack)
        {
            litdanhsachtintuc.Text = LayDanhSachTinTuc();
            litdanhmuctintuc.Text = LayDanhMucTinTuc();
        }
    }
    private string LayDanhMucTinTuc()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.danhmuctincha.Thongtin_danhmuccha();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            s += @"
    <div class='item_drop'>
                    <div class='title_drop " + dt.Rows[i]["MaDmTinCha"] + @"'>
                        " + dt.Rows[i]["TenDmTinCha"] + @"
";
            s += Layimg(dt.Rows[i]["MaDMTinCha"].ToString());

            s += @"         
                    </div>
                    <hr />
                <div class='dropdown_list'>";
            s += LayDanhMucCon(dt.Rows[i]["MaDMTinCha"].ToString());
            s += @"
                    </div>
                </div>

";
        }
        return s;
    }
    private string LayDanhMucCon(string madmtincha)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.DanhMucTin.thongtin_danhmuctin_cha(madmtincha);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            s += @"
                    <a href='/default.aspx?dm=tin-tuc&danhmucphu=danhsach&id=" + dt.Rows[i]["MaDMTin"] + @"' class='danhsach'>
                            <div class='ten'>" + dt.Rows[i]["TenDMTin"] + @"</div>
";
                             s += @"
            <div class='soluong'>(" + (LaySoLuong(dt.Rows[i]["MaDMTin"].ToString())) + @")</div>
    ";
            s+=@"
                        </a>
";
        }
        return s;
    }

    private string LaySoLuong(string v)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.TinTuc.thongtin_tintuc_madmtin(v, id);


        return dt.Rows.Count.ToString();
    }

    private string Layimg(string madmtincha)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.DanhMucTin.thongtin_danhmuctin_cha(madmtincha);
        if (dt.Rows.Count > 0)
        {
            s += @"
 <img src='../../../../style/client/img/icon/down_sp.png'/>
";
        }
        return s;
    }
    private string LayDanhSachTinTuc()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.DanhMucTin.thongtin_danhmuctin_id(id);
        if (dt.Rows.Count > 0)
        {

            s += @"
            <div class='item_r'>
                   <div class='head'>
                            <div class='title'>"+dt.Rows[0]["TenDMTin"]+@"</div>
                        </div>
";
            s += LayThongtintintuc();
            s += @"</div>";
        }
        return s;
    }

    private string LayThongtintintuc()
    {
        string s = "";
        var pageSize = "2"; // Số sản phẩm trên 1 trang
        var condition = "MaDMTin = " + id; // Điều kiện lấy sản phẩm, có thể lấy theo mã danh mục hoặc trạng thái on/off của sản phẩm
        var orderBy = ""; // Trường sắp xếp kết quả
        var ds = DongPhucKhanhLinh.TinTuc.GetDataPaging(_p, pageSize, condition, orderBy);
        var dt = ds.Tables[0];
        for(int i = 0; i<dt.Rows.Count; i++)
        {
            s += @"
                <a href='/default.aspx?dm=tin-tuc&danhmucphu=chitiet&id="+dt.Rows[i]["MaTinTuc"]+@"' class='item_big'>
                            <div class='boder_img'>
                                <div class='WImage'>
                                    <img src='/pic/TinTuc/"+dt.Rows[i]["AnhTinTuc"]+@"' alt='' />
                                </div>
                            </div>
                            <div class='txt'>
                                <div class='title_txt'>"+dt.Rows[i]["TenTinTuc"]+@"</div>
                                <div class='dateview'>
                                    <div class='date'>Ngày đăng: "+dt.Rows[i]["NgayTao"]+@"</div>
                                    <div class='view'>Lượt xem: "+dt.Rows[i]["LuotXem"] +@" lượt</div>
                                </div>
                                <div class='decs'>
                                    "+dt.Rows[i]["MoTa"]+@"
                                </div>
                                <div class='btn'>Xem Chi Tiết</div>
                            </div>
                        </a>
";
        }
        var dtPager = ds.Tables[1];
        var totalRows = dtPager.Rows[0]["TotalRows"].ToString();
        ltrphantrang.Text += PagingExtensions.SpilitPagesNoRewrite(Convert.ToInt32(totalRows), Convert.ToInt32(pageSize), Convert.ToInt32(_p), "/default.aspx?dm=tin-tuc&danhmucphu=danhsach&id=" + id, "active", "normal", "first", "last", "preview", "next");
        return s;

    }
}