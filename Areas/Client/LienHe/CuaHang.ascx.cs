using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_Client_LienHe_CuaHang : System.Web.UI.UserControl
{
  
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            litcuahang.Text += LayCuaHang();
            litvanphong.Text += LayVanPhong();
            litlaylistcuahang.Text += LayListCuaHang();
           litdown.Text += layimgdown();
        }
    }

    private string layimgdown()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.DanhSachCuaHang.thongtin_cuahang_cuahang("Cửa Hàng");
        if(dt.Rows.Count> 0)
        {
            s += @"
                <div class='dropdown'>
                    <div class='wrp'>
                        <div class='title_t'>Danh Sách Cửa Hàng</div>
                         <img class='drop' src='style/client/img/icon/dropdown.png' alt='' />
                    </div>
                </div>
   
";
        }

        return s;
    
}

    

    private string LayListCuaHang()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.DanhSachCuaHang.Thongtin_danhsachcuahang();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if (dt.Rows[i]["ChucNang"].ToString() == "Cửa Hàng")
            {
                s += @"
<div class='item'>
                        <div class='left'>
                            <address class='diachi'>" + dt.Rows[i]["DiaChi"] + @"</address>
                            <a href='tel:" + dt.Rows[i]["SoDienThoai"] + @"' class='tel'>Hotline: " + dt.Rows[i]["SoDienThoai"] + @"</a>
                            <a href='mailto:" + dt.Rows[i]["Email"] + @"' class='email'>Email:" + dt.Rows[i]["Email"] + @"</a>
                        </div>
                        <a data-fancybox='map' href='https://www.google.com/maps/search/?api=1&query=" + dt.Rows[i]["Link"] + @"' class='right'>
                            <img src='style/client/img/icon/ggmap.png' alt='' />
                        </a>
                    </div>";
            }
        }
        return s;
    }

    private string LayVanPhong()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.DanhSachCuaHang.Thongtin_danhsachcuahang();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if(dt.Rows[i]["ChucNang"].ToString() == "Văn Phòng")
            {
                s += @"
<div class='item'>
                        <div class='left'>
                            <address class='diachi'>"+dt.Rows[i]["DiaChi"]+@"</address>
                            <a href='tel:"+dt.Rows[i]["SoDienThoai"] +@"' class='tel'>Hotline: "+dt.Rows[i]["SoDienThoai"] +@"</a>
                            <a href='mailto:"+dt.Rows[i]["SoDienThoai"]+@"' class='email'>Email:"+dt.Rows[i]["Email"]+ @"</a>
                        </div>
                        <a data-fancybox='map' href='https://www.google.com/maps/search/?api=1&query=" + dt.Rows[i]["Link"] + @"' class='right'>
                            <img src='style/client/img/icon/ggmap.png' alt='' />
                        </a>
                    </div>";
            }
        }
            return s;
    }


    private string LayCuaHang()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.DanhSachCuaHang.Thongtin_danhsachcuahang();
        for(int i =0; i<dt.Rows.Count; i++)
        {
            if (dt.Rows[i]["ChucNang"].ToString() == "Văn Phòng")
            {
                s += @"
<a data-fancybox='map' href='https://www.google.com/maps/search/?api=1&query=" + dt.Rows[i]["Link"] + @"'class='WImage'>
    <img src='/pic/AnhCuaHang/" + dt.Rows[i]["AnhCuaHang"] + @"' alt='' />
</a>

";
            }
        }
        return s;
    }
}