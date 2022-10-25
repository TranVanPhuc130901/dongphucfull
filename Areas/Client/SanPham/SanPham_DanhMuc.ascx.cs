using Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_Client_SanPham_SanPham_DanhMuc : System.Web.UI.UserControl
{
    string id = "";
    string SoSPHienThi = "";
    string _p = "1";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];
        if (Request.Params["p"] != null) _p = Request.Params["p"];
        if (!IsPostBack)
        {
            litsanpham.Text = LayDanhSachSanPham();
            LayKhachHangCuaChungToi();
            litdanhmucsp.Text = LayDanhMucSP();
            //LayView();
        }
    }

//    private void LayView()
//    {
//        DataTable dt = new DataTable();
//        dt = DongPhucKhanhLinh.SanPham.Thongtin_sanpham();
        
//            litview.Text += @"
//<div class='view'>Hiển thị 8 trong (" + (SumView(dt.Rows[0]["MaDMSP"].ToString())) + @") sản phẩm</div>
//";
        
//    }

    //private string SumView(string v)
    //{
    //    string s = "";
    //    DataTable dt = new DataTable();
    //    dt = DongPhucKhanhLinh.SanPham.thongtin_sanpham_dmsp(v, id);
 
    //    return dt.Rows.Count.ToString();
    //}

    private string LayDanhMucSP()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.danhmuccha.Thongtin_danhmuccha();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            s += @"
    <div class='item_drop'>
                    <div class='title_drop "+dt.Rows[i]["MaDMCha"]+@"'>
                        " + dt.Rows[i]["TenDMCha"] + @"
";
            s+=Layimg(dt.Rows[i]["MaDMCha"].ToString());

            s += @"         
                    </div>
                    <hr />
                <div class='dropdown_list'>";
            s += LayDanhMucCon(dt.Rows[i]["MaDMCha"].ToString());
            s+=@"
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
        dt = DongPhucKhanhLinh.DanhMucSanPham.thongtin_danhmucsp_cha(madmcha);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            s += @"
                    <a href='/default.aspx?dm=san-pham&danhmucphu=danhsach&id=" + dt.Rows[i]["MaDMSP"] + @"' class='danhsach'>
                            <div class='ten'>" + dt.Rows[i]["TenDMSP"] + @"</div>
";
            s += @"
                            
                        </a>
";
        }
        return s;
    }
//    private string LaySoLuong(string v)
//    {
//        string s = "";
//        DataTable dt = new DataTable();
//        dt = DongPhucKhanhLinh.SanPham.thongtin_sanpham_dmsp(v, id);
//            string soluong = dt.Rows.Count.ToString();
//            s += @"
//        <div class='soluong'>(" + (soluong) + @")</div>
//";
//        return s;
//    }

    private string Layimg(string madmcha)
    {
        string s = "";
        DataTable dt = new DataTable();
      dt =  DongPhucKhanhLinh.DanhMucSanPham.thongtin_danhmucsp_cha(madmcha);
        if (dt.Rows.Count > 0)
        {
            s += @"
 <img class='imgup active' src='../../../../style/client/img/icon/down_sp.png'/>
<img class='imgdown' src='../../../../style/client/img/icon/down_click.png'/>
";
        }
        return s;
    }

    private void LayKhachHangCuaChungToi()
    {
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.KhachHangLienKet.Thongtin_khachhanglienket();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            litkhachhangcuachungtoi.Text += @"
             <a href='' class='item'>
                <div class='itemsmall'>
                    <div class='WImage'>
                        <img src='/pic/KhachHangLienKet/" + dt.Rows[i]["AnhKHLienKet"] + @" ' alt=''>
                    </div>
                    <div class='info'>
                        <div class='name'>" + dt.Rows[i]["TenKHLienKet"] + @"</div>
                        <div class='xemthem'>Xem Chi Tiết</div>
                    </div>
                </div>
                <div class='itemsmall'>
                    <div class='WImage'>
                        <img src='/pic/KhachHangLienKet/" + dt.Rows[i]["AnhKHLienKet"] + @" ' alt=''>
                    </div>
                    <div class='info'>
                       <div class='name'>" + dt.Rows[i]["TenKHLienKet"] + @"</div>
                        <div class='xemthem'>Xem Chi Tiết</div>
                    </div>
                </div>
            </a>
        ";
        }
    }
    private string LayDanhSachSanPham()
    {
        string s = "";
        var pageSize = "2"; // Số sản phẩm trên 1 trang
        var condition = ""; // Điều kiện lấy sản phẩm, có thể lấy theo mã danh mục hoặc trạng thái on/off của sản phẩm
        var orderBy = ""; // Trường sắp xếp kết quả
        var ds = DongPhucKhanhLinh.SanPham.GetDataPaging(_p, pageSize, condition, orderBy);
        var dt = ds.Tables[0];
        //DataTable dt = new DataTable();
        //dt = DongPhucKhanhLinh.SanPham.Thongtin_sanpham();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            s += @"
                    <a href='/default.aspx?dm=san-pham&danhmucphu=chitiet&id=" + dt.Rows[i]["MaSP"] + @"' class='item'>
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
        var dtPager = ds.Tables[1];
        var totalRows = dtPager.Rows[0]["TotalRows"].ToString();
        ltrphantrang.Text += PagingExtensions.SpilitPagesNoRewrite(Convert.ToInt32(totalRows), Convert.ToInt32(pageSize), Convert.ToInt32(_p),
            "/default.aspx?dm=san-pham&danhmucphu=danhmuc", "active", "normal", "first", "last", "preview", "next");
        return s;
    }
}