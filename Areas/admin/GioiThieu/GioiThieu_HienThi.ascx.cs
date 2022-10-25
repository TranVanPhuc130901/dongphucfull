using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_GioiThieu_GioiThieu_HienThi : System.Web.UI.UserControl
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
        dt = DongPhucKhanhLinh.GioiThieu.Thongtin_gioithieu();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            litbanner.Text += @"
        <tr class='magt' id='ma" + dt.Rows[i]["MaGioiThieu"] + @"'>
                <td >" + dt.Rows[i]["TenGioiThieu"] + @" </td>
                <td >" + dt.Rows[i]["NgayTao"] + @" </td>
                <td >" + dt.Rows[i]["LuotXem"] + @" </td>
                <td >" + dt.Rows[i]["MoTa"] + @" </td>
                <td >" + dt.Rows[i]["MaDMGT"] + @" </td>
               <td class='image'><img src='pic/GioiThieu/" + dt.Rows[i]["AnhGT"] + @"'/></td>
                <td class='motagt'>" + dt.Rows[i]["ChiTiet"] + @" </td>
               
            <td>
                <a href='Admin.aspx?dm=gioithieu&cn=sua&id=" + dt.Rows[i]["MaGioiThieu"] + @"'>Sửa</a>
                <a href='javascript:XoaGioiThieu(" + dt.Rows[i]["MaGioiThieu"] + @")'>Xoá</a></td>
         </tr>

";
        }
    }
}