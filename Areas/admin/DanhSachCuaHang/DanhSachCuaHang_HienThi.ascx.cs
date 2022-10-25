using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_DanhSachCuaHang_DanhSachCuaHang_HienThi : System.Web.UI.UserControl
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
        dt = DongPhucKhanhLinh.DanhSachCuaHang.Thongtin_danhsachcuahang();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            litbanner.Text += @"
        <tr class='macuahang' id='ma" + dt.Rows[i]["MaCuaHang"] + @"'>
            
               <td>" + dt.Rows[i]["DiaChi"] + @" </td>
                <td>" + dt.Rows[i]["SoDienThoai"] + @" </td>
                <td>" + dt.Rows[i]["Email"] + @" </td>
                <td>" + dt.Rows[i]["Link"] + @" </td>
                 <td class='image'><img src='pic/AnhCuaHang/" + dt.Rows[i]["AnhCuaHang"] + @"'/></td>
                <td>" + dt.Rows[i]["ChucNang"] + @" </td>
            <td>
                <a href='Admin.aspx?dm=thongtincuahang&cn=sua&id=" + dt.Rows[i]["MaCuaHang"] + @"'>Sửa</a>
                <a href='javascript:XoaDanhSachCuaHang(" + dt.Rows[i]["MaCuaHang"] + @")'>Xoá</a></td>
         </tr>

";
        }
    }
}