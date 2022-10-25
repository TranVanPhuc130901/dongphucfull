using Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_Client_KhachHang_KhachHangDanhGia : System.Web.UI.UserControl
{
    private string _p = "1";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["p"] != null) _p = Request.Params["p"];
        if (!IsPostBack)
        {
            litkhachhang.Text = LayKhachHang();

        }
    }

    private string LayKhachHang()
    {
        var pageSize = "2"; // Số sản phẩm trên 1 trang
        var condition = ""; // Điều kiện lấy sản phẩm, có thể lấy theo mã danh mục hoặc trạng thái on/off của sản phẩm
        var orderBy = ""; // Trường sắp xếp kết quả
        var ds = DongPhucKhanhLinh.KhachHangDanhGia.GetDataPaging(_p, pageSize, condition, orderBy);
        var dt = ds.Tables[0];
        string s = "";
        //DataTable dt = new DataTable();
        //dt = DongPhucKhanhLinh.KhachHangDanhGia.Thongtin_khachhangdanhgia();
        for(int i = 0; i<dt.Rows.Count; i++)
        {
            s += @"
<a data-fancybox='video'
        href='"+dt.Rows[i]["Link"]+@"'
          class='khachhang' >
        <div class='img_res'>
        <div class='WImage'>
           <img src='/pic/KhachHangDanhGia/"+dt.Rows[i]["AnhDanhGia"]+@"' alt='' />
       </div>
      <div class='play'>
          <img src='./img/icon/play.png' alt='' />
     </div>
     </div>
    <div class='text'>"+dt.Rows[i]["TenDanhGia"]+@"</div>
</a>
";
        }
        var dtPager = ds.Tables[1];
        var totalRows = dtPager.Rows[0]["TotalRows"].ToString();
        ltrPaging.Text += PagingExtensions.SpilitPagesNoRewrite(Convert.ToInt32(totalRows), Convert.ToInt32(pageSize), Convert.ToInt32(_p), "/default.aspx?dm=khach-hang&danhmucphu=danhgia", "active", "normal", "first", "last", "preview", "next");
        return s;
    }
}