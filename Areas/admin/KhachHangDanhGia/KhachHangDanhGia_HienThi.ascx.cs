using System;
using System.Data;

public partial class Areas_admin_KhachHangDanhGia_KhachHangDanhGia_HienThi : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LayBanner();
        }
    }

    private void LayBanner()
    {
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.KhachHangDanhGia.Thongtin_khachhangdanhgia();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            litbanner.Text += @"
        <tr class='madanhgia' id='ma" + dt.Rows[i]["MaDanhGia"] + @"'>
               <td >" + dt.Rows[i]["TenDanhGia"] + @" </td>
               <td class='image'><img src='pic/KhachHangDanhGia/" + dt.Rows[i]["AnhDanhGia"] + @"'/></td>
                <td >" + dt.Rows[i]["Link"] + @" </td>
            <td>
                <a href='Admin.aspx?dm=khachhangdanhgia&cn=sua&id=" + dt.Rows[i]["MaDanhGia"] + @"'>Sửa</a>
                <a href='javascript:XoaKhachHangDanhGia(" + dt.Rows[i]["MaDanhGia"] + @")'>Xoá</a></td>
         </tr>

";
        }
    }
}