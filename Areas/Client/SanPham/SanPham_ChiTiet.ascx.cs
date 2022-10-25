using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_Client_SanPham_SanPham_ChiTiet : System.Web.UI.UserControl
{
   protected string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];
        if (!IsPostBack)
        {
            litanhchinh.Text = LayAnhChinh();
            litanhphu.Text = LayAnhPhu(id);
            litthongtin.Text = LayThongTin(id);
            litkhachhangcuachungtoi.Text = LayKhachHangCuaChungToi();
            litthamkhao.Text = LayBaiVietThamKhao();

        }
    }


    private string LayBaiVietThamKhao()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.TinTuc.thongtin_tintuc_5();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            s += @"
 <a href='' class='baiviet'>
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
        return s;
    }
    private string LaySanPhamCungLoai(string iddm)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.SanPham.thongtin_sanpham_dmsp(iddm, id);
        for(int i = 0; i< dt.Rows.Count; i++)
        {
            s += @"
 <a href='/default.aspx?dm=san-pham&danhmucphu=chitiet&id=" + dt.Rows[i]["MaSP"] + @"&iddm=" + dt.Rows[i]["MaDMSP"] + @"' class='item'>
    <div class='WImage'>
        <img src='/pic/SanPham/" + dt.Rows[i]["AnhSP"] + @"' alt='' />
     <div class='layer'></div>
     </div>
     <div class='info'>
             <div class='namesp'>" + dt.Rows[i]["TenSP"] + @"</div>
             <div class='work'>Nhà Hàng, Khách Sạn</div>
      </div>
</a>
"; 
            
        }
        return s;
    }

    private string LayKhachHangCuaChungToi()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.KhachHangLienKet.Thongtin_khachhanglienket();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if (i % 2 == 0) s += @"<div class='item'>";
            s += @"
                <a  href='/default.aspx?dm=khach-hang&danhmucphu=lienket' class='itemsmall'>
                    <div class='WImage'>
                        <img src='/pic/KhachHangLienKet/" + dt.Rows[i]["AnhKHLienKet"] + @" ' alt=''>
                    </div>
                    <div class='info'>
                        <div class='name'>" + dt.Rows[i]["TenKHLienKet"] + @"</div>
                        <div class='xemthem'>Xem Chi Tiết</div>
                    </div>
                </a>

";
            if (i % 2 == 1) s += @"</div>";


        }

        return s;
    }
    private string LayThongTin(string id)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.SanPham.thongtin_sanpham_id(id);
        if (dt.Rows.Count > 0)
        {
            string iddm = dt.Rows[0]["MaDMSP"].ToString();
            litsanphamcungloai.Text += LaySanPhamCungLoai(iddm);

            s += @"

                    <h2 class='title'>"+dt.Rows[0]["TenSP"]+@"</h2>
                    <a href='' class='danhmuc'>Đồng phục nhà hàng</a>
                    <div class='decs'>
                        Mô Tả
                        "+dt.Rows[0]["MoTa"]+ @"
                    </div>
                    <div class='mausac'>
                        <div class='title_mau'>Các loại màu sắc vải</div>
                        <div class='gr_mausac'>
                            <a href='' class='WImage'>
                                <img src='../../../style/client/img/image/xanh.png' alt='' />
                            </a>
                            <a href='' class='WImage'>
                                <img src='../../../style/client/img/image/xanh.png' alt='' />
                            </a>
                            <a href='' class='WImage'>
                                <img src='../../../style/client/img/image/xanh.png' alt='' />
                            </a>
                            <a href='' class='WImage'>
                                <img src='../../../style/client/img/image/xanh.png' alt='' />
                            </a>
                            <a href='' class='WImage'>
                                <img src='../../../style/client/img/image/xanh.png' alt='' />
                            </a>

                            <a href='' class='xemtatca'>Xem Tất cả</a>
                        </div>
                    </div>
                    <div class='size'>
                        <div class='size_title'>Cách chọn Size theo</div>
                        <div class='item'>
                            <span>Cân Nặng</span>
                            <a href='' class='btn'>Xem Tất cả</a>
                        </div>
                        <div class='item'>
                            <span>Số đo</span>
                            <a href='' class='btn'>Xem Tất cả</a>
                        </div>
                    </div>
                    <div class='buy'>
                        <a href='javascript:MuaNgay()' class='baogia'>Nhận báo giá</a>
                        <a href='' class='hotline'>Hotline: 0965 585 368</a>
                    </div>
                    <div class='title_mxh'>Like, Share Mạng xã Hội</div>
                    <div class='mxh'>
                        <a href=''><img src='../../../style/client/img/icon/facebook.svg' alt='' /></a>
                        <a href=''><img src='../../../style/client/img/icon/twitter.svg' alt='' /></a>
                        <a href=''><img src='../../../style/client/img/icon/pinterest.svg' alt='' /></a>
                        <a href=''><img src='../../../style/client/img/icon/linkedin.svg' alt='' /></a>
                    </div>
                    <div class='title_khuyenmai'>Khuyến mãi</div>
                    <div class='khuyenmai'>
                         " + dt.Rows[0]["KhuyenMai"] + @"
                    </div>
                </div>
";
        }
        return s;
    }

    private string LayAnhPhu(string id)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.AnhSP.thongtinanhsanpham_masp(id);
        for(int i = 0; i<dt.Rows.Count; i++)
        {
            s += @"
                <div class='WImage'>
                    <img src='/pic/SanPham/"+dt.Rows[i]["AnhSP"]+@"' alt='' />
                 </div>
";
        }
            return s;
    }

    private string LayAnhChinh()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.SanPham.thongtin_sanpham_id(id);
       if(dt.Rows.Count>0)
        {
            s += @"
 <a href='' class='WImage'>                  
            <img src='/pic/SanPham/" + dt.Rows[0]["AnhSP"] + @"' alt='' />
     </a>
";
        }
        return s;
    }
    //private string LayPhanTrang()
    //{
    //    string s = "";
    //    if (dtPager.Rows.Count > 0 && dt.Rows.Count > 0)
    //    {
    //        var split = PagingCollection.SpilitPages(int.Parse(dtPager.Rows[0]["TotalRows"].ToString()), int.Parse(top), int.Parse(_p), Request.QueryString["title"], "active", "trangkhac", "dau", "cuoi", "prev", "next");
    //        s.Append(split);
    //    }
    //    else
    //    {
    //        s.Append("<div class='emptyresult'>" + LanguageItemExtension.GetnLanguageItemTitleByName(_noResultText) + "</div>");
    //    }

    //    return s.ToString();
    //}
   
}