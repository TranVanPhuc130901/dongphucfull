using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_Client_TinTuc_TinTuc_ChiTiet : System.Web.UI.UserControl
{
    string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];
        if (!IsPostBack)
        {
            litchitiettintuc.Text = LayChiTietTinTuc();
            litdanhmuctin.Text = LayDanhMucTinTuc();
            litbaivietthamkhao.Text = LayBaiVietThamKhao();
        }
    }

    private string LayBaiVietThamKhao()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.TinTuc.thongtin_tintuc_5();
        for(int i = 0; i<dt.Rows.Count; i++)
        {
            if(dt.Rows[i]["MaTinTuc"].ToString() != id)
            {
                s += @"
 <a href='/default.aspx?dm=tin-tuc&danhmucphu=chitiet&id=" + dt.Rows[i]["MaTinTuc"] + @"' class='baiviet'>
                                <div class='WImage'>
                                    <img src='/pic/TinTuc/" + dt.Rows[i]["AnhTinTuc"] + @"' alt='' />
                                </div>
                                <div class='txt'>
                                    <h3>" + dt.Rows[i]["TenTinTuc"] + @"</h3>
                                    <div class='datetime'>
                                        <div class='date'>" + dt.Rows[i]["NgayTao"] + @"</div>
                                        <div class='view'>" + dt.Rows[i]["LuotXem"] + @" Lượt xem</div>
                                    </div>
                                </div>
                            </a>
";
            }
            
        }
        return s;
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
                            <div class='soluong'>(89)</div>
                        </a>
";
        }
        return s;
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

    private string LayChiTietTinTuclienquan(string idtin)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.TinTuc.thongtin_tintuc_madmtin(idtin, id);
        for(int i =0; i<dt.Rows.Count; i++)
        {
                s += @"
<a href='' class='item'>
                                <div class='WImage'>
                                    <img src='/pic/TinTuc/" + dt.Rows[i]["AnhTinTuc"] + @"' alt='' />
                                    <div class='layer'></div>
                                </div>
                                <div class='text'>
                                    <div class='title_i'>" + dt.Rows[i]["TenTinTuc"] + @"</div>
                                    <div class='viewdate'>
                                        <div class='date'>Ngày đăng: " + dt.Rows[i]["NgayTao"] + @"</div>
                                        <div class='view'>" + dt.Rows[i]["LuotXem"] + @" Lượt xem</div>
                                    </div>
                                    <div class='decs'>
                                        " + dt.Rows[i]["MoTa"] + @"
                                    </div>
                                    <div class='btn'>Xem Ngay</div>
                                </div>
                            </a>
";
        }
        return s;
    }

    private string LayChiTietTinTuc()
    {
        CapNhatLuotXem();
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.TinTuc.thongtin_tintuc_id(id);
        if (dt.Rows.Count > 0)
        {
            string idtintuc = dt.Rows[0]["MaDMTin"].ToString();
            litlienquan.Text = LayChiTietTinTuclienquan(idtintuc);
            s += @"
<div class='title'>"+dt.Rows[0]["TenTinTuc"]+@"</div>
                    <div class='datetime'>
                        <div class='date'>Ngày đăng: "+dt.Rows[0]["NgayTao"]+@"</div>
                        <div class='view'>"+dt.Rows[0]["LuotXem"]+ @" Lượt xem</div>
                    </div>
                    <div class='drop_chitiet'>
                        <div class='head'>
                          <img src='../../../style/client/img/icon/menu_number.png' />
                            <img src='../../../style/client/img/icon/drop_white.png' />
                        </div>
                        <div class='box_chitiet'>
                            <div class='item'>
                                <div class='title_ct'>Trang phục nữ sinh Nhật: Khi đồng phục gắn với thời trang</div>
                            </div>
                            <div class='item'>
                                <div class='title_ct'>Đồng phục lâu đời nhất</div>
                            </div>
                            <div class='item'>
                                <div class='title_ct'>Đồng phục học sinh Việt Nam</div>
                                <div class='box_chitiet_drop'>
                                    <div class='danhmuc'>1. Đồng phục thời bao cấp</div>
                                    <div class='danhmuc'>2. Đồng phục hiện đại</div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class='decs'>
                        " + dt.Rows[0]["ChiTietTin"]+@"
                    </div>
";
        }
        return s;

    }

    private void CapNhatLuotXem()
    {
        DongPhucKhanhLinh.TinTuc.CapNhatLuotXemTinTuc(id);
    }
}