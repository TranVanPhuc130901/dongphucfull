using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_Client_TrangChu_TrangChuControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = "";
        string sotinhienthi = "";
        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];
        if (!IsPostBack)
        {
            LayBanner();
            LayDongSanPham();
            LayCongNgheLeft();
            LayCongNgheRight();
            LayKhachHangDanhGia();
            litkhachhangcuachungtoi.Text = LayKhachHangCuaChungToi();
            litnhansu.Text = LayNhanSu();
            littintuc.Text = LayTinTuc(id, sotinhienthi);
        }
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

    private string LayTinTuc(string id, string sotinhienthi)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.TinTuc.thongtin_tintuc_4(id, sotinhienthi);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            s += @"
 <a href='/default.aspx?dm=tin-tuc&danhmucphu=chitiet&id="+dt.Rows[i]["MaTinTuc"]+@"' class='item'>
                <div class='WImage'>
                    <img src='/pic/TinTuc/"+dt.Rows[i]["AnhTinTuc"]+@"' alt=''>
                    <div class='layer'></div>
                </div>
                <div class='info'>
                    <h3 class='title'>"+dt.Rows[i]["TenTinTuc"]+ @"</h3>
                    <div class='datetime'>
                        <div class='date'>" + dt.Rows[i]["NgayTao"] + @"</div>
                        <div class='view'>" + dt.Rows[i]["LuotXem"] + @" lượt xem</div>
                    </div>
                    <div class='decs'>" + dt.Rows[i]["Mota"] + @"</div>
                    <div class='viewnow'>Xem Ngay</div>
                </div>
            </a>
";
        }
            return s;
    }

    private string LayNhanSu()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.NhanSu.Thongtin_nhansu();
        for (int i = 0; i < dt.Rows.Count; i++) {
            s += @"
                 <div class='item'>
                <div class='WImage'>
                    <img src='/pic/NhanSu/"+dt.Rows[i]["AnhNhanSu"] +@"' alt=''>
                </div>
                <div class='info'>
                    <div class='name'>"+dt.Rows[i]["TenNhanSu"]+@"</div>
                    <div class='work'>"+dt.Rows[i]["ViTri"]+@"</div>
                </div>
            </div>
                
                ";
        }
        return s;
    }


    private void LayKhachHangDanhGia()
    {
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.KhachHangDanhGia.Thongtin_khachhangdanhgia();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            litkhachhangdanhgia.Text += @"
            <a href='"+dt.Rows[i]["Link"]+@"' class='item' data-fancybox='video'>
                <div class='WImage'>
                    <img src='/pic/KhachHangDanhGia/"+dt.Rows[i]["AnhDanhGia"] + @"' alt=''>
                </div>
                <div class='logo_yt'>
                    <img src='style/client/img/icon/youtube.png' alt=''>
                </div>
                <div class='title'>
                   " + dt.Rows[i]["TenDanhGia"] + @"
                </div>
            </a>
";
        }
           
    }

    private void LayCongNgheRight()
    {
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.CongNghe.Thongtin_congnghe();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            litcongngheright.Text += @"
 <div class='congnghebtn' data='congnghe" + dt.Rows[i]["MaCN"] + @"'>" + dt.Rows[i]["TenCN"] + @" </div>

";

        }
    }

    private void LayCongNgheLeft()
    {
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.CongNghe.Thongtin_congnghe();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
           var hienthi = dt.Rows[i]["HienThi"].ToString();
            litcongngheleft.Text += @"
 <div class='txt congnghe"+dt.Rows[i]["MaCN"] + @" "+(hienthi == "1" ? "active" : "")+@"' data='congnghe" + dt.Rows[i]["MaCN"] + @"'>
     <div class='title_i'>" + dt.Rows[i]["TenCN"] + @" </div>
    <div class='decs'> " + dt.Rows[i]["MoTaCN"] + @"</div>     
   <a href = 'default.aspx?dm=congnghe&danhmucphu=hienthi&" + dt.Rows[0]["MaCN"] + @"' > Xem Thêm</a>
</div>
";
        }
        }

    private void LayDongSanPham()
    {
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.DanhMucSanPham.Thongtin_danhmucsp();
        for(int i = 0; i<dt.Rows.Count; i++)
        {
            litdongsanpham.Text += @"
        <div class='item'>
                <div class='WImage'>
                    <img src='/pic/DanhMucSP/"+dt.Rows[i]["AnhDM"] +@"' alt=''>
                </div>
                <div class='title_i'>
                    <h3>"+dt.Rows[i]["TenDMSP"]+ @"</h3>
                    <a class='btn' href='/default.aspx?dm=san-pham&danhmucphu=danhsach&id=" + dt.Rows[i]["MaDMSP"] + @"'>Xem Ngay</a>
                </div>
        </div>
";
        }
    }

    private void LayBanner()
    {
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.Banner.Thongtin_Banner();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            var trangthai = dt.Rows[i]["TrangThai"].ToString();
            if(trangthai == "True")
            {
                litbanner.Text += @"
                <div class='WImage'>
                   <img src='/pic/Banner/" + dt.Rows[i]["AnhBanner"] + @"' />
                </div>

";
            }
            
        }

    }
}
