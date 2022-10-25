using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_Client_TinTuc_TinTuc : System.Web.UI.UserControl
{
    string id = "";
    string sotinhienthi = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            litheadtintuc.Text = LayDanhMucTin();
            litdanhmuctin.Text = LayDanhMucTinTuc();
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

    private string Laytieudetin(string MaDmTin)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.TinTuc.thongtin_tintuc_madmtin(MaDmTin, id);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            string idtintuc = dt.Rows[0]["MaTinTuc"].ToString();   
            if(dt.Rows[i]["MaTinTuc"].ToString() != idtintuc)
            {
                s += @" <div class='gr_itemsmall'>
<a href='/default.aspx?dm=tin-tuc&danhmucphu=chitiet&id=" + dt.Rows[i]["MaTinTuc"] + @"' class='item_small'>" + dt.Rows[i]["TenTinTuc"] + @"</a>
</div>";
            }

            
        }
        return s;
    }

    private string LayDanhMucTin()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.DanhMucTin.Thongtin_danhmuctin();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            s += @"
             <div class='item_r'>
                        <div class='head'>
                            <div class='title'>" + dt.Rows[i]["TenDMTin"] + @"</div>
                            <a href='/default.aspx?dm=tin-tuc&danhmucphu=danhsach&id=" + dt.Rows[i]["MaDMTin"] + @"' class='link'>Xem Tất cả</a>
                        </div>
";
            s += LayTinTuc(dt.Rows[i]["MaDMTin"].ToString(), dt.Rows[i]["SoTinHienThi"].ToString());

            s += @"</div>";
        }
        return s;
    }

    private string LayTinTuc(string MaDMTin, string sotinhienthi)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.TinTuc.thongtin_tintuc_1(MaDMTin, sotinhienthi);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            

            s += @"
         <a href='/default.aspx?dm=tin-tuc&danhmucphu=chitiet&id=" + dt.Rows[i]["MaTinTuc"] + @"' class='item_big'>
                            <div class='boder_img'>
                                <div class='WImage'>
                                    <img src='/pic/TinTuc/" + dt.Rows[i]["AnhTinTuc"] + @"' alt='' />
                                </div>
                            </div>
                            <div class='txt'>
                                <h3 class='title_txt'>" + dt.Rows[i]["TenTinTuc"] + @"</h3>
                                <div class='dateview'>
                                    <div class='date'>Ngày đăng: " + dt.Rows[i]["NgayTao"] + @"</div>
                                    <div class='view'>Lượt xem: " + dt.Rows[i]["LuotXem"] + @" lượt</div>
                                </div>
                                <div class='decs'>
                                    " + dt.Rows[i]["MoTa"] + @"
                                </div>
                                <div class='btn'>Xem Chi Tiết</div>
                            </div>
        </a> ";
            string idtin = dt.Rows[i]["MaDmTin"].ToString();
            string idt = dt.Rows[i]["MaTinTuc"].ToString();
            if(dt.Rows[0]["MaTinTuc"].ToString() == idt)
            {
            s += Laytieudetin(idtin);
            }


        }
        return s;
    }

       
    }
